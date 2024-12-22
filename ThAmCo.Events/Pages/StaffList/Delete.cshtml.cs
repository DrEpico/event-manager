using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.StaffList
{
    public class DeleteModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DeleteModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staff Staff { get; set; } = default!;

        /// <summary>
        /// Pull staff record from the database by ID on page load.
        /// </summary>
        /// <param name="id">ID of the staff.</param>
        /// <returns>Reload page</returns>
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FirstOrDefaultAsync(m => m.StaffId == id);

            if (staff == null)
            {
                return NotFound();
            }
            else
            {
                Staff = staff;
            }
            return Page();
        }

        /// <summary>
        /// Remove staff from the database.
        /// </summary>
        /// <param name="id">ID of a staff</param>
        /// <returns>Redirect to the staff list page.</returns>
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FindAsync(id);
            if (staff != null)
            {
                Staff = staff;
                _context.Staff.Remove(Staff);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
