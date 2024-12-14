using System.Text.Json;
using ThAmCo.Events.Dtos;
using ThAmCo.Events.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Routing;

namespace ThAmCo.Events.Services
{
    public class VenueReservationService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueReservationEndpoint = "/Reservations";
        private readonly HttpClient _httpClient;
        private readonly EventDbContext _context;
        public VenueReservationService(HttpClient httpClient, EventDbContext context)
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
            string staffId = await AssignStaffing(eventId, date, startTime, endTime);

            // Create the reservation DTO
            var reservation = new VenueReservationDto //TODO: move this to service (pass down data not as object yet)
            {
                StaffId = staffId,
                EventDate = date,
                VenueCode = venueCode
            };
            var url = ServiceBaseUrl + VenueReservationEndpoint;
            HttpResponseMessage response;
            try
            {
                response = await _httpClient.PostAsJsonAsync(url, reservation);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                // Handle exception or log it
                throw new HttpRequestException("Failed to post reservation.", ex);
            }

            if (response == null)
            {
                throw new InvalidOperationException("The response was not received.");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var confirm = JsonSerializer.Deserialize<ConfirmReservationDto>(jsonResponse, jsonOptions);

            if (confirm == null)
            {
                throw new ArgumentNullException(nameof(response),
                    "The reservation response is null");
            }

            return confirm;
        }

        /// <returns>Returns string type StaffId because the reservation DTO takes string type</returns>
        private async Task<string> AssignStaffing(int eventId, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                // Get the list of unavailable staff IDs
                var unavailableStaffIds = await _context.Staffing
                    .Where(s => s.Event.Date == eventDate && s.Event.StartTime < endTime && s.Event.EndTime > startTime)
                    .Select(s => s.StaffId)
                    .Distinct()
                    .ToListAsync();

                // Filter available staff
                var availableStaff = await _context.Staff
                    .Where(s => !unavailableStaffIds.Contains(s.StaffId))
                    .ToListAsync();

                // Extract available managers
                var availableManagers = availableStaff
                    .Where(s => s.Role == "Manager")
                    .ToList();

                if (!availableManagers.Any())
                {
                    throw new Exception("No available staff for the specified time period.");
                }

                // Select a random staff member
                var random = new Random();
                var selectedStaff = availableManagers[random.Next(availableManagers.Count)];

                // Create a staffing record
                var staffing = new Staffing
                {
                    StaffId = selectedStaff.StaffId,
                    EventId = eventId
                };

                // Save the staffing record to the database
                _context.Staffing.Add(staffing);
                await _context.SaveChangesAsync();

                return selectedStaff.StaffId.ToString();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error assigning staffing: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }

                // Return a meaningful message or rethrow the exception
                throw new Exception("An error occurred while assigning staffing. Please try again.", ex);
            }
        }

        public async Task<GetVenueDto?> GetVenueReservationAsync(string reference)
        {
            var url = $"{ServiceBaseUrl}{VenueReservationEndpoint}/{Uri.EscapeDataString(reference)}";
            try
            {
                var response = await _httpClient.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    // Log the error or handle it appropriately
                    return null;
                }

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<GetVenueDto>(jsonResponse, jsonOptions);
            }
            catch (Exception ex)
            {
                // Log exception details
                Console.WriteLine($"Failed to fetch venue reservation: {ex.Message}");
                return null;
            }
        }

    }
}
