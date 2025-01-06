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

namespace ThAmCo.Events.Pages.EventList
{
    [Authorize(Policy = "EmployeeAccess")]
    public class EditModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public EditModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        // The Event object bound to the form data on the page.
        [BindProperty]
        public Event Event { get; set; } = default!;

        // Handles GET requests to fetch an event for editing based on its ID.
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            // If no ID is provided, return a 404 Not Found result.
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the event from the database by its ID.
            var selectedEvent =  await _context.Events.FirstOrDefaultAsync(m => m.EventId == id);
            if (selectedEvent == null)
            {
                return NotFound();
            }
            Event = selectedEvent;
            return Page();
        }

        // Handles POST requests to update the event details in the database.
        public async Task<IActionResult> OnPostAsync()
        {
            // If the form data is invalid, reload the page with validation messages.
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var selectedEvent = await _context.Events.FirstOrDefaultAsync(m => m.EventId == Event.EventId);

            if (selectedEvent == null)
            {
                return NotFound();
            }

            // Update the properties of the tracked entity
            selectedEvent.Title = Event.Title;

            try { 
                // Save the changes to the database.
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Handle concurrency issues if the event no longer exists.
                if (!EventExists(Event.EventId))
                {
                    return NotFound();
                }
                else
                {
                    Console.WriteLine($"Concurrency exception occurred. {ex}");
                }
            }

            return RedirectToPage("./Index");
        }

        // Helper method to check if an event exists in the database by its ID.
        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }

        //TODO: Add a modal that allows venues to be booked for existing events.
    }
}
