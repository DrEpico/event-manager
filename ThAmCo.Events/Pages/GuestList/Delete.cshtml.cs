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
    public class DeleteModel : PageModel
    {
        private readonly EventDbContext _context;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(EventDbContext context, ILogger<DeleteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public GuestViewModel GuestVM { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Find the guest with the given ID.
            var guest = await _context.Guests.FirstOrDefaultAsync(m => m.GuestId == id);

            if (guest == null)
            {
                return NotFound();
            }

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

        /// <summary>
        /// Removes the guest record from the database.
        /// </summary>
        /// <param name="id">ID of the guest.</param>
        /// <returns>Redirect to the guest list page</returns>
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guests
                .Include(g => g.GuestBookings)
                .FirstOrDefaultAsync(m => m.GuestId == id);

            if (guest == null)
            {
                return NotFound();
            }

            try
            {
                _context.GuestBookings.RemoveRange(guest.GuestBookings);
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();

                TempData["StatusMessage"] = "Guest successfully deleted.";
                _logger.LogInformation("Guest {GuestId} was deleted", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting guest {GuestId}", id);
                TempData["StatusMessage"] = "Error deleting guest. Please try again.";
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
