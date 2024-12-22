using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using ThAmCo.Events.Dtos;
using Xunit.Abstractions;

namespace ThAmCo.Events.Services
{
    /// <summary>
    /// Service to interact with the Venue Availability API.
    /// </summary>
    public class VenueAvailabilityService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueEndpoint = "/availability";
        private readonly HttpClient _httpClient;

        public VenueAvailabilityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        // <summary>
        /// Retrieves available venues for a specific event type and date.
        /// </summary>
        /// <param name="eventType">
        /// The event type, which must be a string with exactly 3 characters.
        /// </param>
        /// <param name="date">
        /// The date for which to check venue availability. The time component is ignored.
        /// </param>
        /// <returns>A list of VenueAvailabilityDto objects representing available venues.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the deserialized venue availability response is null.
        /// </exception>
        public async Task<List<VenueAvailabilityDto>> GetAvailableVenuesAsync(
            [FromQuery, MinLength(3), MaxLength(3), Required] string eventType,
            [FromQuery, Required] DateTime date)
        {
            //TODO: Add validation for time inputs before 8:00 and after 23:00
            // Calculates the beginning and end of the provided date.
            var beginDate = date.Date; // Sets time to 00:00
            var endDate = date.Date.AddDays(1).AddTicks(-1); // Sets time to 23:59:59.9999999
            var response = await _httpClient.GetAsync($"{ServiceBaseUrl}{VenueEndpoint}?eventType={eventType}&beginDate={beginDate:o}&endDate={endDate:o}");
            response.EnsureSuccessStatusCode(); // Throws an exception for non-success HTTP status codes.

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var items = JsonSerializer.Deserialize<List<VenueAvailabilityDto>>(jsonResponse, jsonOptions);

            if (items == null)
            {
                throw new ArgumentNullException(nameof(items), "The venue availability response is null");
            }

            return items;
        }

    }
}
