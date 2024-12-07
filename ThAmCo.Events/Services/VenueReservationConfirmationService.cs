using System.Text.Json;
using ThAmCo.Events.Data;
using ThAmCo.Events.Dtos;

//namespace ThAmCo.Events.Services
//{
//    public class VenueReservationConfirmationService
//    {
//        const string ServiceBaseUrl = "https://localhost:7088/api";
//        const string VenueReservationEndpoint = "/Reservations";
//        private readonly HttpClient _httpClient;
//        private readonly EventDbContext _context;

//        public VenueReservationConfirmationService(HttpClient httpClient, EventDbContext context)
//        {
//            _httpClient = httpClient;
//            _context = context;
//        }

//        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
//        {
//            PropertyNameCaseInsensitive = true
//        };

//        public async Task<ConfirmReservationDto> GetReservationConfirmation(string reference)
//        {
//            var url = ServiceBaseUrl + VenueReservationEndpoint;
//            HttpResponseMessage response;
//            try
//            {
//                response = await _httpClient.GetAsync(reference);
//            }
//            catch (Exception ex)
//            {
//                // Handle exception or log it
//                throw new HttpRequestException("Failed to post reservation.", ex);
//            }

//            if (response == null)
//            {
//                throw new InvalidOperationException("The response was not received.");
//            }
//        }
//    }
//}
