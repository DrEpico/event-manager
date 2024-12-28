using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Catering.Data;
using ThAmCo.Catering.Dtos;

namespace ThAmCo.Catering.Controllers
{
    /// <summary>
    /// Controller for managing food bookings in the catering system.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FoodBookingsController : ControllerBase
    {
        private readonly CateringDbContext _context;

        public FoodBookingsController(CateringDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a list of all food bookings.
        /// GET: api/FoodBookings
        /// </summary>
        /// <returns>A list of food bookings in the form of output DTOs.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodBookingOutputDto>>> GetFoodBookings()
        {
            var FoodBookings = await _context.FoodBookings
                .Include(fb => fb.Menu) // Include related Menu entity
                .ToListAsync();

            var FoodBookingsDto = FoodBookings
                .Select(fb => new FoodBookingOutputDto(
                    fb.ClientReferenceId,
                    fb.NumberOfGuests,
                    fb.Menu?.MenuName //TODO: catch possible null reference 
                ));

            return Ok(FoodBookingsDto);
        }

        /// <summary>
        /// Gets a specific food booking by its ID.
        /// GET: api/FoodBookings/5
        /// </summary>
        /// <param name="id">The ID of the food booking to retrieve.</param>
        /// <returns>The requested food booking.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodBooking>> GetFoodBooking(int id)
        {
            var foodBooking = await _context.FoodBookings.FindAsync(id);

            if (foodBooking == null)
            {
                return NotFound();
            }

            return foodBooking;
        }

        /// <summary>
        /// Updates an existing food booking.
        /// PUT: api/FoodBookings/5
        /// </summary>
        /// <param name="foodBookingDto">The updated food booking data.</param>
        /// <returns>The updated food booking data or an appropriate status code.</returns>
        [HttpPut]
        public async Task<ActionResult<FoodBookingOutputDto>> PutFoodBooking(FoodBookingEditInputDto foodBookingDto)
        {
            var foodBooking = await _context.FoodBookings
                .FirstOrDefaultAsync(fb => fb.ClientReferenceId == foodBookingDto.ClientReferenceId);

            // Ensure at least one field is being updated
            if (!foodBookingDto.NumberOfGuests.HasValue && !foodBookingDto.MenuId.HasValue)
            {
                return BadRequest("At least either of 'NumberOfGuests' or 'MenuId' should have a value to update booking.");
            }

            if (foodBooking == null)
            {
                return NotFound("The Client Reference ID doesn't exist.");
            }

            // Check if the submitted values are identical to the existing record
            if (foodBooking.NumberOfGuests == foodBookingDto.NumberOfGuests.Value 
                && foodBooking.MenuId == foodBookingDto.MenuId.Value)
            {
                return StatusCode(304, "Not modified. The submitted values are identical to the existing record.");
            } 
            else 
            {
                if (foodBookingDto.NumberOfGuests.HasValue)
                    foodBooking.NumberOfGuests = foodBookingDto.NumberOfGuests.Value;
                if (foodBookingDto.MenuId.HasValue) 
                    foodBooking.MenuId = foodBookingDto.MenuId.Value;
            }

            try
            {
                _context.Entry(foodBooking).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodBookingExists(foodBooking.FoodBookingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFoodBooking", new { id = foodBooking.FoodBookingId }, foodBookingDto);
        }

        /// <summary>
        /// Creates a new food booking.
        /// POST: api/FoodBookings
        /// </summary>
        /// <param name="foodBookingDto">The food booking data.</param>
        /// <returns>The created food booking data.</returns>
        [HttpPost]
        public async Task<ActionResult<FoodBookingOutputDto>> PostFoodBooking(FoodBookingInputDto foodBookingDto)
        {   
            var foodBooking = new FoodBooking();
            
            try
            {
                // Assign DTO values to the entity. 
                // Validation is done at DTO.
                foodBooking.NumberOfGuests = foodBookingDto.NumberOfGuests;
                foodBooking.MenuId = foodBookingDto.MenuId;

                // Placeholder for generating a unique Client Reference ID
                // foodBooking.ClientReferenceId = GenerateClientReferenceId();

                _context.FoodBookings.Add(foodBooking);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            // Retrieve the newly created FoodBooking with the related Menu entity
            var createdFoodBooking = await _context.FoodBookings
                .Include(fb => fb.Menu)
                .FirstOrDefaultAsync(fb => fb.FoodBookingId == foodBooking.FoodBookingId);

            // If no matching booking is found, return a 404 (shouldn't occur in normal scenarios)
            if (createdFoodBooking == null)
            {
                return NotFound();
            }

            var clientRef = GenerateClientReferenceId();

            // Map the entity to the output DTO
            var foodBookingOutputDto = new FoodBookingOutputDto(
                clientRef,
                createdFoodBooking.NumberOfGuests,
                createdFoodBooking.Menu?.MenuName // Handle potential null reference
            );

            // Return the single object
            return CreatedAtAction("GetFoodBooking", new { id = foodBooking.FoodBookingId }, foodBookingOutputDto);
        }

        /// <summary>
        /// Deletes a food booking by its client reference ID.
        /// DELETE: api/FoodBookings/5
        /// </summary>
        /// <param name="clientReferenceId">The client reference ID of the food booking to delete.</param>
        /// <returns>No content if successful, or an error status code.</returns>
        [HttpDelete("{clientReferenceId}")]
        public async Task<IActionResult> DeleteFoodBooking(int clientReferenceId)
        {
            var foodBooking = await _context.FoodBookings
                .FirstOrDefaultAsync(fb => fb.ClientReferenceId == clientReferenceId);

            if (foodBooking == null)
            {
                return NotFound();
            }

            try
            {
                _context.FoodBookings.Remove(foodBooking);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        /// <summary>
        /// Checks if a food booking exists by its ID.
        /// </summary>
        /// <param name="id">The ID of the food booking.</param>
        /// <returns>True if the booking exists; otherwise, false.</returns>
        private bool FoodBookingExists(int id)
        {
            return _context.FoodBookings.Any(e => e.FoodBookingId == id);
        }

        private int GenerateClientReferenceId()
        {
            // Fetch the last ClientReferenceId from the database
            var lastClientReferenceId = _context.FoodBookings
                .OrderByDescending(fb => fb.ClientReferenceId)
                .Select(fb => fb.ClientReferenceId)
                .FirstOrDefault();

            return lastClientReferenceId + 1;
        }
    }
}
