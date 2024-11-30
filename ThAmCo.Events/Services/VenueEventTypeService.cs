using System.Text.Json;
using System.Text.Json.Serialization;
using ThAmCo.Events.Dtos;

namespace ThAmCo.Events.Services
{
    public class VenueEventTypeService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueEndpoint = "/EventTypes";
        private readonly HttpClient _httpClient;

        public VenueEventTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task<List<VenueEventTypeDto>> GetEventTypesAsync()
        {
            var response = await _httpClient.GetAsync(ServiceBaseUrl + VenueEndpoint);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var items = JsonSerializer.Deserialize<List<VenueEventTypeDto>>(jsonResponse, jsonOptions);

            if (items == null)
            {
                throw new ArgumentNullException(nameof(response), "The EventType response is null.");
            }

            return items;
        }
    }
}