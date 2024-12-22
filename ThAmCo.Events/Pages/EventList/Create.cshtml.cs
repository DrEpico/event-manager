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
    /// <summary>
    /// PageModel for creating a new event using the venue service classes.
    /// </summary>
    public class CreateModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;
        private readonly VenueAvailabilityService _venueAvailabilityService;
        private readonly VenueEventTypeService _venueEventTypeService;
        private readonly VenueReservationService _venueReserveService;

        /// <summary>
        /// Constructor to initialize the CreateModel class with dependencies.
        /// </summary>
        /// <param name="context">The database context for managing events.</param>
        /// <param name="venueAvailability">Service to check venue availability.</param>
        /// <param name="venueEventType">Service to retrieve event types.</param>
        /// <param name="venueReservation">Service to reserve venues.</param>
        public CreateModel(EventDbContext context, 
            VenueAvailabilityService venueAvailability, 
            VenueEventTypeService venueEventType, 
            VenueReservationService venueReservation)
        {
            _context = context;
            _venueAvailabilityService = venueAvailability;
            _venueEventTypeService = venueEventType;
            _venueReserveService = venueReservation;
        }

        // The Event object used to bind form data for creating an event.
        [BindProperty]
        public Event Event { get; set; } = default!;

        // List of available event types for selection.
        public IEnumerable<SelectListItem> EventTypes { get; set; } = default!;

        // List of available venues for selection.
        [BindProperty]
        public IEnumerable<SelectListItem> Venues { get; set; } = default!;

        /// <summary>
        /// Handles GET requests to load event types into the page for selection.
        /// </summary>
        /// <returns>The page with populated event types.</returns>
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

        /// <summary>
        /// Handles POST requests to search for available venues based on the event details.
        /// </summary>
        /// <returns>The page with available venues populated for selection.</returns>
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

        /// <summary>
        /// Handles POST requests to create an event and reserve a venue.
        /// </summary>
        /// <returns>Redirects to a confirmation page upon success or reloads the page on error.</returns>
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
                    VenueReference = Event.VenueReference
                };
                // If successful, save the event locally
                _context.Events.Add(Event);
                await _context.SaveChangesAsync();

                // Call the reservation service 
                var reservationReference = await _venueReserveService.PostReservationVenueAsync(
                Event.Date, Event.VenueReference, Event.EventId, Event.StartTime, Event.EndTime);

                // Update the Event object with the actual reservation reference
                Event.VenueReference = reservationReference.Reference;


                _context.Entry(Event).State = EntityState.Modified; // Mark as modified
                await _context.SaveChangesAsync(); // Save the changes


                // Redirect to a confirmation or events list page
                return RedirectToPage("./ConfirmReservation", reservationReference);
            }
            catch (HttpRequestException ex)
            {
                // Log the error or show an error message
                ModelState.AddModelError(string.Empty, $"Error reserving venue: {ex.Message}");
                return Page();
            }
        }
    }
}
