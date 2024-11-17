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
    [Route("api/[controller]")]
    [ApiController]
    public class FoodBookingsController : ControllerBase
    {
        private readonly CateringDbContext _context;

        public FoodBookingsController(CateringDbContext context)
        {
            _context = context;
        }

        // GET: api/FoodBookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodBookingOutputDto>>> GetFoodBookings()
        {
            var FoodBookings = await _context.FoodBookings
                .Include(fb => fb.Menu)
                .ToListAsync();

            var FoodBookingsDto = FoodBookings
                .Select(fb => new FoodBookingOutputDto(
                    fb.ClientReferenceId,
                    fb.NumberOfGuests,
                    fb.Menu.MenuName //TODO: catch possible null reference 
                ));

            return Ok(FoodBookingsDto);
        }

        // GET: api/FoodBookings/5
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

        // PUT: api/FoodBookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutFoodBooking(FoodBookingEditInputDto foodBookingDto)
        {
            var foodBooking = await _context.FoodBookings
                .FirstOrDefaultAsync(fb => fb.ClientReferenceId == foodBookingDto.ClientReferenceId);
            
            if(!foodBookingDto.NumberOfGuests.HasValue && !foodBookingDto.MenuId.HasValue)
            {
                return BadRequest("At least either of 'NumberOfGuests' or 'MenuId' should have a value to update booking.");
            }

            if (foodBooking == null)
            {
                return NotFound("The Client Reference ID doesn't exist.");
            }

            //Ignore possisble null values as they're handled at line 63
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

            return NoContent();
        }

        // POST: api/FoodBookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodBookingOutputDto>> PostFoodBooking(FoodBookingInputDto foodBookingDto)
        {   
            var foodBooking = new FoodBooking();
            
            try
            { 
                //Validation is done at DTO so I don't think I need to check for null in here again?
                foodBooking.NumberOfGuests = foodBookingDto.NumberOfGuests;
                foodBooking.MenuId = foodBookingDto.MenuId;
                //TODO:
                //foodBooking.ClientReferenceId = GenerateClientReferenceId();


                _context.FoodBookings.Add(foodBooking);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return CreatedAtAction("GetFoodBooking", new { id = foodBooking.FoodBookingId }, foodBookingDto);
        }

        // DELETE: api/FoodBookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodBooking(int id)
        {
            var foodBooking = await _context.FoodBookings.FindAsync(id);
            if (foodBooking == null)
            {
                return NotFound();
            }

            _context.FoodBookings.Remove(foodBooking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodBookingExists(int id)
        {
            return _context.FoodBookings.Any(e => e.FoodBookingId == id);
        }
    }
}
