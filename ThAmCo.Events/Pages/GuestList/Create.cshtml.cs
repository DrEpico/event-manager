using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThAmCo.Events.Data;
using Microsoft.AspNetCore.Authorization;

namespace ThAmCo.Events.Pages.GuestList
{
    [Authorize(Policy = "EmployeeAccess")]
    public class CreateModel : PageModel
    {
        private readonly EventDbContext _context;

        public CreateModel(EventDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Guest Guest { get; set; } = default!;

        /// <summary>
        /// Save the guest record to the database.
        /// </summary>
        /// <returns>Redirect to the guest list page.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Guests.Add(Guest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
