using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.GuestList
{
    public class DetailsModel : PageModel
    {
        private readonly EventDbContext _context;

        public DetailsModel(EventDbContext context)
        {
            _context = context;
        }

        //Event object to navigate to events associated with a guest
        public Guest Guest { get; set; } = default!;

        //Guest can have no bookings so it is nullable
        public Guest? Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            // Find the guest with the given ID.
            var guest = await _context.Guests.FirstOrDefaultAsync(m => m.GuestId == id);
            // Find the event bookings with the given guest ID.
            var guestEvent = await _context.Guests
                .Include(g => g.GuestBookings) // link to bookings
                .ThenInclude(gb => gb.Event) // link to events accosiated with the bookings
                .FirstOrDefaultAsync(m => m.GuestId == id);

            if (guest == null)
            {
                return NotFound();
            }
            else
            {
                Guest = guest;
                Event = guestEvent;
            }
            return Page();
        }
    }
}
