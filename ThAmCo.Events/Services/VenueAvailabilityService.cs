using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using ThAmCo.Events.Dtos;
using Xunit.Abstractions;

namespace ThAmCo.Events.Services
{
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

        public async Task<List<VenueAvailabilityDto>> GetAvailableVenuesAsync(
            [FromQuery, MinLength(3), MaxLength(3), Required] string eventType,
            [FromQuery, Required] DateTime date)
        {
            //TODO: Add validation for time inputs before 8:00 and after 23:00
            var beginDate = date.Date; // Sets time to 00:00
            var endDate = date.Date.AddDays(1).AddTicks(-1); // Sets time to 23:59:59.9999999
            var response = await _httpClient.GetAsync($"{ServiceBaseUrl}{VenueEndpoint}?eventType={eventType}&beginDate={beginDate:o}&endDate={endDate:o}");
            response.EnsureSuccessStatusCode();

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
