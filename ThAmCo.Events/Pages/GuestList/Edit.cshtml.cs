using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

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
        public Guest Guest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest =  await _context.Guests.FirstOrDefaultAsync(m => m.GuestId == id);
            if (guest == null)
            {
                return NotFound();
            }
            Guest = guest;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Guest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestExists(Guest.GuestId))
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

        //private bool GuestExists(int id)
        //{
        //    return _context.Guests.Any(e => e.GuestId == id);
        //}

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
            guest.Phone = "XXXXXXXXXX";

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
