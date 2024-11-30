using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using ThAmCo.Events.Dtos;
using ThAmCo.Events.Services;

namespace ThAmCo.Events.Pages.EventList
{
    public class CreateModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;
        private readonly VenueAvailabilityService _venueAvailabilityService;
        private readonly VenueEventTypeService _venueEventTypeService;

        //public List<string> EventTypes { get; set; }
        public CreateModel(ThAmCo.Events.Data.EventDbContext context, VenueAvailabilityService venueAvailability, VenueEventTypeService venueEventType)
        {
            _context = context;
            _venueAvailabilityService = venueAvailability;
            _venueEventTypeService = venueEventType;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        [BindProperty]
        public string SelectedEventType { get; set; } = default!;// To store the selected event type

        public IEnumerable<SelectListItem> EventTypes { get; set; } = default!;
        public IEnumerable<SelectListItem> Venues { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var eventTypes = await _venueEventTypeService.GetEventTypesAsync();

            EventTypes = eventTypes.Select(et => new SelectListItem
            {
                Text = et.Title, // Displayed text
                Value = et.Id.ToString() // Value sent to the server
            });

            return Page();
        }

        public async Task<IActionResult> OnPostSearchVenuesAsync()
        {
            if (Event.Date == null || string.IsNullOrEmpty(Event.EventType))
            {
                ModelState.AddModelError("", "Please provide both a date and an event type to search for venues.");
                return Page();
            }

            // Fetch venues from the service
            var availableVenues = await _venueAvailabilityService.GetAvailableVenuesAsync(Event.EventType, Event.Date + Event.StartTime, Event.Date + Event.StartTime);

            Venues = availableVenues.Select(v => new SelectListItem
            {
                Text = v.Name
                //Value = v.Id.ToString()
            });

            // Preserve the event types in case the page reloads
            var eventTypes = await _venueEventTypeService.GetEventTypesAsync();
            EventTypes = eventTypes.Select(et => new SelectListItem
            {
                Text = et.Title,
                Value = et.Id.ToString()
            });

            return Page();
        }


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
