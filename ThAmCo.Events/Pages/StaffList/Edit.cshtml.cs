using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.StaffList
{
    public class EditModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public EditModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staff Staff { get; set; } = default!;

        /// <summary>
        /// Pull staff instance by ID from the database.
        /// </summary>
        /// <param name="id">ID of the staff.</param>
        /// <returns>Reload page</returns>
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff =  await _context.Staff.FirstOrDefaultAsync(m => m.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }
            Staff = staff;
            return Page();
        }

        /// <summary>
        /// Save changes to staff record to database.
        /// </summary>
        /// <returns>Direct to the staff details page.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Staff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(Staff.StaffId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new { id = Staff.StaffId });
        }

        /// <summary>
        /// Helper method to check for a staff instance by ID.
        /// </summary>
        /// <param name="id">ID of the staff.</param>
        /// <returns>True if staff exsits, otherwise False.</returns>
        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.StaffId == id);
        }
    }
}
