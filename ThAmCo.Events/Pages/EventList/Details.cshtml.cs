using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.EventList
{
    public class DetailsModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DetailsModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; } = default!;

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

        public async Task<IActionResult> OnPostAddGuestAsync(string GuestName, string email, string phoneNum)
        {
            if (string.IsNullOrEmpty(GuestName))
            {
                ModelState.AddModelError(string.Empty, "Guest name is required.");
                return Page();
            }

            // Assuming EventId is passed as a route parameter
            var eventId = Event.EventId;

            Guest guest = new Guest(GuestName, email, phoneNum);

            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();

            var newGuest = new GuestBooking
            {
                EventId = eventId,
                GuestId = guest.GuestId,
            };

            _context.GuestBookings.Add(newGuest);
            await _context.SaveChangesAsync();

            //return RedirectToPage("./Details", new { id = eventId });
            return Page();
        }

    }
}
