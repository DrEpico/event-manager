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
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DetailsModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        public Guest Guest { get; set; } = default!;
        //Event object to navigate to events associated with a guest
        public Guest? Event { get; set; } = default!;
        //Guest can have no bookings so it is nullable

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guests.FirstOrDefaultAsync(m => m.GuestId == id);
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
