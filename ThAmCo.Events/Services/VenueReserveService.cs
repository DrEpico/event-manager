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
            //Task: Get a list of staff that are available for the specified time period and
            //  create a staffing record by assinging a random staff.

            //P;C get the list of staff 
            //  somehow filter out the pre-occupied fellas by joining a couple tables Staff -> Staffing -> Event -> Event time
            //  then return a random staff ID and save a staffing record to the database
            List<Staff> allStaff;

            try
            {
                allStaff = await _context.Staff
                    .Include(e => e.Staffings)
                    .ThenInclude(s => s.Event)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the error details for debugging
                Console.WriteLine($"Error fetching staff from database: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                throw new Exception("An error occurred while retrieving staff data. Check database configuration.", ex);
            }

            // Check if staff data is null or empty
            if (allStaff == null || !allStaff.Any())
            {
                throw new Exception("No staff records found in the database.");
            }

            // Filter available staff
            var availableStaff = allStaff
                .Where(staff => !staff.Staffings
                    .Any(staffing => staffing.Event.StartTime < endTime && staffing.Event.EndTime > startTime))
                .ToList();

            if (!availableStaff.Any())
            {
                throw new Exception("No available staff for the specified time period.");
            }

            // Select a random staff member
            var random = new Random();
            var selectedStaff = availableStaff[random.Next(availableStaff.Count)];

            // Create a new staffing record
            var staffing = new Staffing
            {
                StaffingId = selectedStaff.StaffId,
                EventId = eventId
            };

            try
            {
                _context.Staffing.Add(staffing);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving staffing record: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                throw new Exception("An error occurred while saving the staffing record.", ex);
            }

            return selectedStaff.StaffId.ToString();
        }
    }
}
