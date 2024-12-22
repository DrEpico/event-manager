using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.StaffList
{
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
        public Staff Staff { get; set; } = default!;
        /// <summary>
        /// Populate the staff table with a new record.
        /// </summary>
        /// <returns>Redirect to staff list page.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Staff.Add(Staff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
