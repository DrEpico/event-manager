using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using ThAmCo.Events.ViewModels;

namespace ThAmCo.Events.Pages.GuestList
{
    public class EditModel : PageModel
    {
        private readonly EventDbContext _context;
        private readonly ILogger<EditModel> _logger;

        public EditModel(EventDbContext context, ILogger<EditModel> logger)
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

            var guest = await _context.Guests
                .Include(g => g.GuestBookings)
                    .ThenInclude(gb => gb.Event)
                .FirstOrDefaultAsync(m => m.GuestId == id);

            if (guest == null)
            {
                return NotFound();
            }

            // Map data model to view model
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var guest = await _context.Guests.FindAsync(GuestVM.GuestId);

            if (guest == null)
            {
                return NotFound();
            }

            // Map view model back to data model
            guest.Name = GuestVM.Name;
            guest.Email = GuestVM.Email;
            guest.Phone = GuestVM.Phone;

            try
            {
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Guest updated successfully!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestExists(GuestVM.GuestId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostAnonymiseGuestAsync(int guestId)
        {
            var guest = await _context.Guests.FindAsync(guestId);

            if (guest == null)
            {
                _logger.LogWarning("Attempt to anonymize non-existent guest with ID: {GuestId}", guestId);
                return NotFound();
            }

            string anonymizedIdentifier = GenerateAnonymizedIdentifier();
            guest.Name = anonymizedIdentifier;
            guest.Email = $"{anonymizedIdentifier}@anonymized.com";
            guest.Phone = "XXXX-XXX-XXX";

            try
            {
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Guest data has been successfully anonymized.";
                _logger.LogInformation("Guest {GuestId} successfully anonymized", guestId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to anonymize guest {GuestId}", guestId);
                TempData["ErrorMessage"] = "Failed to anonymize guest data. Please try again.";
                return Page();
            }

            return RedirectToPage("./Index");
        }

        private bool GuestExists(int id)
        {
            return _context.Guests.Any(e => e.GuestId == id);
        }

        private string GenerateAnonymizedIdentifier()
        {
            return $"ANON-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}