using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using ThAmCo.Events.ViewModels;

namespace ThAmCo.Events.Pages.GuestList
{
    public class DetailsModel : PageModel
    {
        private readonly EventDbContext _context;

        public DetailsModel(EventDbContext context)
        {
            _context = context;
        }

        public GuestViewModel? GuestVM { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guests
                .Include(g => g.GuestBookings)
                    .ThenInclude(gb => gb.Event)
                .FirstOrDefaultAsync(m => m.GuestId == id);

            if (guest == null)
            {
                return NotFound();
            }

            // Map the data model to view model
            GuestVM = new GuestViewModel
            {
                GuestId = guest.GuestId,
                Name = guest.Name,
                Email = guest.Email,
                Phone = guest.Phone,
                Bookings = guest.GuestBookings.Select(gb => new GuestViewModel.GuestBookingSummary
                {
                    EventId = gb.EventId,
                    EventTitle = gb.Event?.Title ?? "Unknown Event",
                    EventDate = gb.Event?.Date ?? DateTime.MinValue,
                    HasAttended = gb.HasAttended,
                    IsCancelled = gb.IsCancelled
                }).ToList()
            };

            return Page();
        }
    }
}
