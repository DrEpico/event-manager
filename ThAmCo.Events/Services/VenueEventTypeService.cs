using System.Text.Json;
using ThAmCo.Events.Dtos;

namespace ThAmCo.Events.Services
{
    public class VenueEventTypeService
    {
        // Base URL for the external service
        const string ServiceBaseUrl = "https://localhost:7088/api";
        // Endpoint for accessing venue event types.
        const string VenueEndpoint = "/EventTypes";
        // HTTP client for sending requests to the API.
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the VenueEventTypeService with the provided HttpClient.
        /// </summary>
        /// <param name="httpClient">The HttpClient used for API calls.</param>
        public VenueEventTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // JSON serialization options to handle case-insensitive property mapping.
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Retrieves a list of event types from the API.
        /// </summary>
        /// <returns>A list of VenueEventTypeDto objects.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the API response is null.</exception>
        public async Task<List<VenueEventTypeDto>> GetEventTypesAsync()
        {
            // Sends a GET request to the API endpoint.
            var response = await _httpClient.GetAsync(ServiceBaseUrl + VenueEndpoint);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Deserializes the JSON response into a list of VenueEventTypeDto objects.
            var items = JsonSerializer.Deserialize<List<VenueEventTypeDto>>(jsonResponse, jsonOptions);

            if (items == null)
            {
                throw new ArgumentNullException(nameof(response), "The EventType response is null.");
            }

            return items;
        }
    }
}