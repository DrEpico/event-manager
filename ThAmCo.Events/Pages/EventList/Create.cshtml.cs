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
        private readonly VenueReserveService _venueReserveService;

        //public List<string> EventTypes { get; set; }
        public CreateModel(ThAmCo.Events.Data.EventDbContext context, VenueAvailabilityService venueAvailability, VenueEventTypeService venueEventType, VenueReserveService venueReservation)
        {
            _context = context;
            _venueAvailabilityService = venueAvailability;
            _venueEventTypeService = venueEventType;
            _venueReserveService = venueReservation;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public IEnumerable<SelectListItem> EventTypes { get; set; } = default!;
        [BindProperty]
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

        //Don't tell me event creation and venue reservation should be separate because i spent the entire weekend on this 😶
        public async Task<IActionResult> OnPostSearchVenuesAsync()
        {
            if (Event.Date == null || string.IsNullOrEmpty(Event.EventType))
            {
                ModelState.AddModelError("", "Please provide both a date and an event type to search for venues.");
                return Page();
            }

            // Fetch venues from the service
            var availableVenues = await _venueAvailabilityService.GetAvailableVenuesAsync(
                Event.EventType,
                Event.Date
                //Event.Date + Event.StartTime, 
                //Event.Date + Event.StartTime
            );

            Venues = availableVenues.Select(v => new SelectListItem
            {
                Text = v.Name + " - £" + v.CostPerHour + " - Capacity: " + v.Capacity,
                Value = v.Code
            });

            // Preserve the event types in case the page reloads
            var eventTypes = await _venueEventTypeService.GetEventTypesAsync();
            EventTypes = eventTypes.Select(et => new SelectListItem
            {
                Text = et.Title,
                Value = et.Id
            });

            return Page();
        }

        public async Task<IActionResult> OnPostReserveVenueAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //TODO: method to assign one random staff (id) to the event (id)
            //TODO: Add code to populate staffing record using the data mentioned above; 
            try
            {
                Event = new Event
                {
                    Title = Event.Title,
                    Date = Event.Date,
                    StartTime = Event.StartTime,
                    EndTime = Event.EndTime,
                    EventType = Event.EventType,
                    VenueCode = Event.VenueCode
                };
                // If successful, save the event locally
                _context.Events.Add(Event);
                await _context.SaveChangesAsync();

                // Call the reservation service 
                var response = await _venueReserveService.PostReservationVenueAsync(
                    Event.Date, Event.VenueCode, Event.EventId, Event.StartTime, Event.EndTime);
                //response.EnsureSuccessStatusCode();

                _context.Entry(Event).State = EntityState.Modified; // Mark the entity as modified
                await _context.SaveChangesAsync(); // Save the changes

                // Redirect to a confirmation or events list page
                return RedirectToPage("./Create"); 
            }
            catch (HttpRequestException ex)
            {
                // Log the error or show an error message
                ModelState.AddModelError(string.Empty, $"Error reserving venue: {ex.Message}");
                return Page();
            }
        }



        //// For more information, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Events.Add(Event);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}
    }
}
