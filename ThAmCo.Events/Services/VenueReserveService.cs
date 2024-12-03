﻿using System.Text.Json;
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
        {   //got absolutely no clue what the link should look like 

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
                EventId = eventId
            };

            _context.Staffing.Add(staffing);
            await _context.SaveChangesAsync();

            return selectedStaff.StaffId.ToString();
        }
    }
}