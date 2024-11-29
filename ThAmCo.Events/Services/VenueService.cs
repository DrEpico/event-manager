using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using System.Text.Json;
using ThAmCo.Events.Dtos;

namespace ThAmCo.Events.Services
{
    public class VenueService
    {
        const string ServiceBaseUrl = "https//localhost:7088/api";
        const string VenueEndpoint = "/availabiliy";

        private readonly HttpClient _httpClient;

        public VenueService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }
}
