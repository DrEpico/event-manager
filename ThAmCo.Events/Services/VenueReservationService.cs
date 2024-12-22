using System.Text.Json;
using ThAmCo.Events.Dtos;
using ThAmCo.Events.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Routing;

namespace ThAmCo.Events.Services
{
    /// <summary>
    /// Service for managing venue reservations and related operations.
    /// </summary>
    public class VenueReservationService
    {
        const string ServiceBaseUrl = "https://localhost:7088/api";
        const string VenueReservationEndpoint = "/Reservations";
        private readonly HttpClient _httpClient;
        // Database context for accessing and updating the local database.
        private readonly EventDbContext _context;

        /// <summary>
        /// Initializes a new instance of the VenueReservationService with the provided HttpClient and DbContext.
        /// </summary>
        /// <param name="httpClient">HTTP client for API calls.</param>
        /// <param name="context">Database context for local data operations.</param>
        public VenueReservationService(HttpClient httpClient, EventDbContext context)
        {
            _httpClient = httpClient;
            _context = context;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Makes a venue reservation for the specified event details.
        /// </summary>
        /// <param name="date">Event date.</param>
        /// <param name="venueCode">Code of the venue to be reserved.</param>
        /// <param name="eventId">ID of the event requiring the reservation.</param>
        /// <param name="startTime">Start time of the event.</param>
        /// <param name="endTime">End time of the event.</param>
        /// <returns>A confirmation DTO containing reservation details.</returns>
        public async Task<ConfirmReservationDto> PostReservationVenueAsync(DateTime date, string venueCode, int eventId, TimeSpan startTime, TimeSpan endTime)
        {
            // Assign a staff member to the event.
            string staffId = await AssignStaffing(eventId, date, startTime, endTime);

            // Create a DTO for the reservation.
            var reservation = new VenueReservationDto //TODO: move this to service (pass down data not as object yet)
            {
                StaffId = staffId,
                EventDate = date,
                VenueCode = venueCode
            };
            // Post the reservation to the API.
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

            // Deserialize the confirmation response.
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var confirm = JsonSerializer.Deserialize<ConfirmReservationDto>(jsonResponse, jsonOptions);

            if (confirm == null)
            {
                throw new ArgumentNullException(nameof(response),
                    "The reservation response is null");
            }

            return confirm;
        }

        /// <summary>
        /// Assigns a "Manager" level staff to an event based on availability and role.
        /// </summary>
        /// <param name="eventId">ID of the event.</param>
        /// <param name="eventDate">Date of the event.</param>
        /// <param name="startTime">Start time of the event.</param>
        /// <param name="endTime">End time of the event.</param>
        /// <returns>The ID of the assigned staff member.</returns>
        private async Task<string> AssignStaffing(int eventId, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                // Find unavailable staff based on overlapping events.
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

                // Select a random manager from the available ones.
                var random = new Random();
                var selectedStaff = availableManagers[random.Next(availableManagers.Count)];

                // Create a new staffing record and save it to the database.
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

        public async Task<GetVenueDto?> DeleteVenueReservationAsync(string reference)
        {
            var eventByReference = await _context.Events.FirstOrDefaultAsync(m => m.VenueReference == reference.Trim());
            if (eventByReference == null)
            {
                Console.WriteLine("Event not found with the given reference.");
                return null;
            }

            var url = $"{ServiceBaseUrl}{VenueReservationEndpoint}/{Uri.EscapeDataString(reference.Trim())}";
            try
            {
                var response = await _httpClient.DeleteAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Failed to delete venue reservation.");
                    return null;
                }

                // Update the event only after successful API call
                eventByReference.VenueReference = null;
                eventByReference.IsCancelled = true;
                await _context.SaveChangesAsync();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<GetVenueDto>(jsonResponse, jsonOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to delete venue reservation: {ex.Message}");
                return null;
            }
        }
    }
}
