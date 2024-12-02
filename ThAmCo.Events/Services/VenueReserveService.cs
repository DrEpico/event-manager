using System.Text.Json;
using ThAmCo.Events.Dtos;
using ThAmCo.Events.Data;
using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Events.Services
{
    public class VenueReserveService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueReservationEndpoint = "/Reservations";
        private readonly HttpClient _httpClient;
        private readonly EventDbContext _context;
        public VenueReserveService(HttpClient httpClient, EventDbContext context)
        {
            _httpClient = httpClient;
            _context = context;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task PostReservationVenueAsync(VenueReservationDto reservation, int id, TimeSpan startTime, TimeSpan endTime)
        {   //got absolutely no clue what the link should look like 

            // Serialize the DTO into JSON
            var jsonContent = new StringContent(
                JsonSerializer.Serialize(reservation),
                System.Text.Encoding.UTF8,
                "application/json");

            //TODO: Need to make sure 
            // Post the serialized JSON to the API
            var response = await _httpClient.PostAsync($"{ServiceBaseUrl}{VenueReservationEndpoint}/PostReservation", jsonContent);

            // Handle the response if necessary
            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not 2xx
        }

        private async Task AssignStaffing(int id, TimeSpan startTime, TimeSpan endTime)
        {
            //Task: Get a list of staff that are available for the specified time period and
            //  create a staffing record by assinging a random staff.

            //P;C get the list of staff 
            //  somehow filter out the pre-occupied fellas by joining a couple tables Staff -> Staffing -> Event -> Event time
            //  then return a random staff ID and save a staffing record to the database
            var allStaff = await _context.Staff
                .Include(e => e.Staffings)
                .ThenInclude(s => s.Event)
                .ToListAsync();

            var availableStaff = allStaff
                .Where(staff => !staff.Staffings
                    .Any(staffing => staffing.Event.StartTime < endTime && staffing.Event.EndTime > startTime))
                .ToList();

            if (!availableStaff.Any())
            {
                throw new Exception("No available staff for the specified time period.");
            }

            var random = new Random();
            var selectedStaff = availableStaff[random.Next(availableStaff.Count)];

            var staffing = new Staffing
            {
                StaffingId = selectedStaff.StaffId,
                EventId = id
            };

            _context.Staffing.Add(staffing);
            await _context.SaveChangesAsync();
        }
    }
}
