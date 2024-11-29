using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using ThAmCo.Events.Services;

namespace ThAmCo.Events.Pages.EventList
{
    public class CreateModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;
        private readonly VenueService _venueService;

        public List<VenueService> Venues { get; set; } = [];


        //public List<string> EventTypes { get; set; }
        public CreateModel(ThAmCo.Events.Data.EventDbContext context, VenueService venueService)
        {
            _context = context;
            _venueService = venueService;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            //Venues = await _venueService.GetAvailableVenuesAsync();
            var eventTypes = await _context.Events
                .Select(e => e.EventType)
                .Distinct()
                .ToListAsync();

            EventTypes = eventTypes.Select(type => new SelectListItem
            {
                Text = type, // What is displayed to the user
                Value = type // What is sent when the form is submitted
            });

            return Page();
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        // Dropdown options
        public IEnumerable<SelectListItem> EventTypes { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Events.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
