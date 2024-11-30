using System.Text.Json;

namespace ThAmCo.Events.Services
{
    public class VenueEventTypeService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueEndpoint = "/EventType";
        private readonly HttpClient _httpClient;

        public VenueEventTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }
}