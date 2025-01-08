using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using Microsoft.AspNetCore.Authorization;

namespace ThAmCo.Events.Pages.StaffList
{
    [Authorize(Policy = "EmployeeAccess")]
    public class DetailsModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DetailsModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        public Staff Staff { get; set; } = default!;

        /// <summary>
        /// Pull joined staff record and events record associated with the staff on load.
        /// </summary>
        /// <param name="id">ID of the staff.</param>
        /// <returns>Reload page</returns>
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staff = await _context.Staff
                .Include(s => s.Staffings.
                    Where(st => st.Event.IsCancelled == false && st.Event.Date > DateTime.Now))
                .ThenInclude(st => st.Event)
                .FirstOrDefaultAsync(s => s.StaffId == id);

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
    }
}
