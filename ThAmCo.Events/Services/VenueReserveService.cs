using System.Text.Json;
using ThAmCo.Events.Dtos;
using ThAmCo.Events.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Routing;

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

        public async Task<ConfirmReservationDto> PostReservationVenueAsync(DateTime date, string venueCode, int eventId, TimeSpan startTime, TimeSpan endTime)
        {  
            string staffId = await AssignStaffing(eventId, startTime, endTime);

            // Create the reservation DTO
            var reservation = new VenueReservationDto //TODO: move this to service (pass down data not as object yet)
            {
                StaffId = staffId,
                EventDate = date,
                VenueCode = venueCode
            };
            var url = ServiceBaseUrl + VenueReservationEndpoint;
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, reservation);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var confirm = JsonSerializer.Deserialize<ConfirmReservationDto>(jsonResponse, jsonOptions);

            if (confirm != null)
            {
                throw new ArgumentNullException(nameof(response),
                    "The revervation response is null");
            }

            return confirm;
        }

        /// <returns>Returns string type StaffId because the reservation DTO takes string type</returns>
        private async Task<string> AssignStaffing(int eventId, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                // Fetch staff with their staffing records, including associated events
                var allStaff = await _context.Staff
                    .Include(s => s.Staffings)
                    .ThenInclude(st => st.Event)
                    .ToListAsync();

                // Filter for available staff
                var availableStaff = allStaff
                    .Where(staff =>
                        // Check if the staff has no conflicting staffing assignments
                        !staff.Staffings.Any(staffing =>
                            staffing.Event != null &&
                            // Check for time overlap
                            !(staffing.Event.StartTime >= endTime ||
                              staffing.Event.EndTime <= startTime)))
                    .ToList();

                if (!availableStaff.Any())
                {
                    throw new Exception("No available staff for the specified time period.");
                }

                // Randomly select an available staff member
                var random = new Random();
                var selectedStaff = availableStaff[random.Next(availableStaff.Count)];

                // Create staffing record
                var staffing = new Staffing
                {
                    StaffId = selectedStaff.StaffId,
                    EventId = eventId
                };

                _context.Staffing.Add(staffing);
                await _context.SaveChangesAsync();

                return selectedStaff.StaffId.ToString();
            }
            catch (Exception ex)
            {
                // Log the full exception details
                throw; // Rethrow to maintain original error handling
            }
        }
    }
}
