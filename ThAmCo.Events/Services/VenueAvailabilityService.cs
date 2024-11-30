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
            [FromQuery, Required] DateTime beginDate,
            [FromQuery, Required] DateTime endDate)
        {
            if (beginDate > endDate)
                throw new ArgumentException("The begin date must be earlier than or equal to the end date.");

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
