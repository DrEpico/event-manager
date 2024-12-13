using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
        public GetVenueDto VenueCode { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectedEvent = await _context.Events.FirstOrDefaultAsync(m => m.EventId == id);
            var eventGuests = await _context.Events
                .Include(e => e.GuestBookings) // e = event
                .ThenInclude(gb => gb.Guest) // gb = guestBookings
                .FirstOrDefaultAsync(g => g.EventId == id); // g = guest

            if (selectedEvent == null)
            {
                return NotFound(); 
            }
            else
            {
                Event = selectedEvent;
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

        //public async Task<IActionResult> OnGetVenueCodeAsync(int )
        //{

        //}

    }
}
