using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.EventList
{
    public class DeleteModel : PageModel
    {
        private readonly EventDbContext _context;

        public DeleteModel(EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        /// <summary>
        /// Takes ID of the event from the form and save the record in memory for future manipulation.
        /// </summary>
        /// <param name="id">ID of the event.</param>
        /// <returns>Reload page</returns>
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Find the event with the given ID.
            var selectedEvent = await _context.Events.FirstOrDefaultAsync(m => m.EventId == id);

            if (selectedEvent == null)
            {
                return NotFound();
            }
            else
            {
                Event = selectedEvent;
            }
            return Page();
        }

        /// <summary>
        /// Delete the event record from the database.
        /// </summary>
        /// <param name="id">The ID of the event.</param>
        /// <returns>Load event list page</returns>
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectedEvent = await _context.Events.FindAsync(id);
            if (selectedEvent != null)
            {
                Event = selectedEvent;
                _context.Events.Remove(Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
