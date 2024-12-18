﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ThAmCo.Events.Data;
using ThAmCo.Events.Dtos;
using ThAmCo.Events.Services;

namespace ThAmCo.Events.Pages.EventList
{
    public class DetailsModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;
        private readonly VenueReservationService _venueReservationService;

        public DetailsModel(ThAmCo.Events.Data.EventDbContext context, VenueReservationService venueService)
        { 
            _context = context;
            _venueReservationService = venueService;
        }

        public Event Event { get; set; } = default!;

        [BindProperty]
        public GetVenueDto Venue { get; set; } = default!;

        public List<Staff> Assistants { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events
                .Include(e => e.GuestBookings)
                    .ThenInclude(gb => gb.Guest)
                .Include(e => e.Staffings)
                    .ThenInclude(s => s.Staff)
                .FirstOrDefaultAsync(e => e.EventId == id);

            if (Event == null)
            {
                return NotFound();
            }

            Assistants = await _context.Staff
                .Where(s => s.Role == "Assistant" || s.Role == "First Aider")
                .ToListAsync();

            //Check if certain types of events have first aider assigned or not
            CheckFristAiderRequirement();

            // Fetch the venue if the reference exists
            if (!string.IsNullOrEmpty(Event.VenueReference))
            {
                Venue = await _venueReservationService.GetVenueReservationAsync(Event.VenueReference);
            }
            else
            {
                Venue = null; // Handle unreserved venue case
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAddGuestAsync(
            int EventId, string GuestName, string Email, string Phone)
        {
            if (string.IsNullOrEmpty(GuestName))
            {
                ModelState.AddModelError(string.Empty, "Guest name is required.");
                return Page();
            }

            // Ensure the event exists
            var selectedEvent = await _context.Events.FindAsync(EventId);
            if (selectedEvent == null)
            {
                return NotFound();
            }

            // Create and save the guest
            var guest = new Guest
            {
                Name = GuestName,
                Email = Email,
                Phone = Phone
            };
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();

            var newGuest = new GuestBooking
            {
                EventId = EventId,
                GuestId = guest.GuestId,
            };
            _context.GuestBookings.Add(newGuest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = EventId });
        }

        public async Task<IActionResult> OnPostCancelBookingAsync(int GuestBookingId, int EventId)
        {
            // Find the guest booking
            var booking = await _context.GuestBookings.FindAsync(GuestBookingId);

            if (booking == null)
            {
                return NotFound(); // Handle the case where the booking doesn't exist
            }

            // Mark the booking as cancelled
            booking.IsCancelled = true;
            await _context.SaveChangesAsync();

            // Refresh the Event data
            Event = await _context.Events
                .Include(e => e.GuestBookings)
                .ThenInclude(gb => gb.Guest)
                .FirstOrDefaultAsync(e => e.EventId == EventId);

            return Page(); // Return to the current page to show updated data
        }

        public async Task<IActionResult> OnPostRemoveStaffAsync(int StaffId, int EventId)
        {
            var staffing = await _context.Staffing
                .FirstOrDefaultAsync(s => s.StaffId == StaffId && s.EventId == EventId);

            if (staffing == null) return NotFound();

            _context.Staffing.Remove(staffing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = EventId });
        }

        public async Task<IActionResult> OnPostAddStaffAsync(int EventId, int StaffId)
        {
            if (StaffId == 0)
            {
                ModelState.AddModelError(string.Empty, "Please select a valid staff member.");
                return Page();
            }

            var selectedEvent = await _context.Events.FindAsync(EventId);
            if (selectedEvent == null)
            {
                return NotFound();
            }

            var staffing = new Staffing
            {
                EventId = EventId,
                StaffId = StaffId
            };
            _context.Staffing.Add(staffing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = EventId });
        }

        private void CheckFristAiderRequirement()
        {
            if(Event.EventType == "EXH" || Event.EventType == "FES" || Event.EventType == "CMP")
            {
                if(!Event.Staffings.Any(s => s.Staff.Role == "First Aider"))
                {
                    ModelState.AddModelError(string.Empty, "Warning: This event requires at least one first-aider");
                }
            }
        }

        public async Task<IActionResult> OnPostDeleteVenueReservationAsync(int EventId)
        {
            if (EventId == null)
            {
                return NotFound();
            }

            // Fetch the event from the database
            Event = await _context.Events.FindAsync(EventId);
            //Event = await _context.Events
            //    .Include(e => e.GuestBookings)
            //        .ThenInclude(gb => gb.Guest)
            //    .Include(e => e.Staffings)
            //        .ThenInclude(s => s.Staff)
            //    .FirstOrDefaultAsync(e => e.EventId == EventId);

            if (Event == null)
            {
                return NotFound();
            }

            // Fetch and delete the venue reservation if a reference exists
            if (!string.IsNullOrEmpty(Event.VenueReference))
            {
                Venue = await _venueReservationService.DeleteVenueReservationAsync(Event.VenueReference);

                // Optionally clear the venue reference from the Event
                Event.VenueReference = null;
                await _context.SaveChangesAsync();
            }
            else
            {
                Venue = null; // Handle unreserved venue case
            }

            return RedirectToPage("./Details", new { id = EventId });
            //return Page();
        }

    }
}
