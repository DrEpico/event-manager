using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.StaffingList
{
    public class DeleteModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DeleteModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staffing Staffing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing = await _context.Staffing.FirstOrDefaultAsync(m => m.StaffingId == id);

            if (staffing == null)
            {
                return NotFound();
            }
            else
            {
                Staffing = staffing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing = await _context.Staffing.FindAsync(id);
            if (staffing != null)
            {
                Staffing = staffing;
                _context.Staffing.Remove(Staffing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
