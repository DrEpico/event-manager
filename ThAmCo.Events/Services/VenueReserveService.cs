using System.Text.Json;
using ThAmCo.Events.Dtos;

namespace ThAmCo.Events.Services
{
    public class VenueReserveService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueReservationEndpoint = "/Reservations";
        private readonly HttpClient _httpClient;

        public VenueReserveService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task PostReservationVenueAsync(VenueReservationDto reservation)
        {   //got absolutely no clue what the link should look like 

            // Serialize the DTO into JSON
            var jsonContent = new StringContent(
                JsonSerializer.Serialize(reservation),
                System.Text.Encoding.UTF8,
                "application/json");

            // Post the serialized JSON to the API
            var response = await _httpClient.PostAsync($"{ServiceBaseUrl}{VenueReservationEndpoint}/Postservation", jsonContent);

            // Handle the response if necessary
            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not 2xx
        }
    }
}
