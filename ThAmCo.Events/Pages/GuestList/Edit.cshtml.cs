using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using Microsoft.AspNetCore.Authorization;

namespace ThAmCo.Events.Pages.GuestList
{
    [Authorize(Policy = "EmployeeAccess")]
    public class EditModel : PageModel
    {
        private readonly EventDbContext _context;
        private readonly ILogger<EditModel> _logger;

        /// <summary>
        /// Constructor to initialize the EditModel class with dependencies.
        /// </summary>
        /// <param name="context">The database context for managing event data.</param>
        /// <param name="logger">Logger for capturing application events and errors.</param>
        public EditModel(EventDbContext context, ILogger<EditModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        // The Guest object bound to the form data for editing.
        [BindProperty]
        public Guest Guest { get; set; } = default!;

        /// <summary>
        /// Handles the GET request to retrieve and display a guest for editing.
        /// </summary>
        /// <param name="id">The ID of the guest to retrieve.</param>
        /// <returns>The page with the guest's details populated for editing, or NotFound if the guest does not exist.</returns>
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

        /// <summary>
        /// Handles the POST request to update a guest's details.
        /// </summary>
        /// <returns>Redirects to the index page on success, or reloads the page on validation failure.</returns>
        /// <exception cref="DbUpdateConcurrencyException">
        /// Logged if the guest being updated no longer exists in the database.
        /// </exception>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Attach the guest entity to the context and mark it as modified
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
                    Console.WriteLine("Concurrency exception occurred.");
                }
            }

            return RedirectToPage("./Index");
        }

        /// <summary>
        /// Handles the POST request to anonymize a guest's data.
        /// </summary>
        /// <param name="guestId">The ID of the guest to anonymize.</param>
        /// <returns>Redirects to the index page on success or reloads the page on failure.</returns>
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

        /// <summary>
        /// Helper method to checks if a guest exists in the database.
        /// </summary>
        /// <param name="id">The ID of the guest to check.</param>
        /// <returns>True if the guest exists; otherwise, false.</returns>
        private bool GuestExists(int id)
        {
            return _context.Guests.Any(e => e.GuestId == id);
        }

        /// <summary>
        /// Helper method to generate a unique anonymized identifier for a guest.
        /// </summary>
        /// <returns>A string representing the anonymized identifier.</returns>
        private string GenerateAnonymizedIdentifier()
        {
            return $"ANON-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
