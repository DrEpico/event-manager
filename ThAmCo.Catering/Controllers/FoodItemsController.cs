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
    public class FoodItemsController : ControllerBase
    {
        private readonly CateringDbContext _context;

        public FoodItemsController(CateringDbContext context)
        {
            _context = context;
        }

        // GET: api/FoodItems
        [HttpGet("GetFoodItemsFull")]
        public async Task<ActionResult<IEnumerable<FoodItem>>> GetFoodItemsFull()
        {
            return await _context.FoodItems.ToListAsync();
        }

        [HttpGet("GetFoodItems")]
        public async Task<ActionResult<IEnumerable<FoodItemDto>>> GetFoodItems()
        {
            try
            {
                var FoodItems = await _context.FoodItems
                    .Select(fi => new FoodItemDto(fi.Description, fi.UnitPrice))
                    .ToListAsync();

                if (!FoodItems.Any())
                    return NotFound("No item found");

                return Ok(FoodItems);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/FoodItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodItemDto>> GetFoodItem(int id)
        {
            var foodItem = await _context.FoodItems.FindAsync(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            var foodItemDto = new FoodItemDto();
            foodItemDto.Description = foodItem.Description;
            foodItemDto.UnitPrice = foodItem.UnitPrice;

            return foodItemDto;
        }

        // PUT: api/FoodItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodItem(int id, FoodItem foodItem)
        {
            if (id != foodItem.FoodItemId)
            {
                return BadRequest();
            }

            _context.Entry(foodItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodItemExists(id))
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

        //PUT: api/EditFoodItem/{id}
        [HttpPut("EditFoodItem/{id}")]
        public async Task<IActionResult> EditFoodItem(int id, FoodItemDto foodItemDto)
        {
            // Find the existing FoodItem by ID
            var foodItem = await _context.FoodItems.FindAsync(id);

            // Check if the item exists
            if (foodItem == null)
            {
                return NotFound();
            }

            // Update the existing FoodItem's properties with values from the DTO
            if (!string.IsNullOrEmpty(foodItemDto.Description))
            {   
                foodItem.Description = foodItemDto.Description;
            }
            
            if (foodItemDto.UnitPrice.HasValue)
            {
                foodItem.UnitPrice = foodItemDto.UnitPrice.Value;// Use .Value to get the underlying float
            }

            // Save the changes to the database
            await _context.SaveChangesAsync();

            // Return a NoContent response to indicate a successful update
            return NoContent();
        }

        // POST: api/FoodItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<FoodItem>> PostFoodItem(FoodItemDto foodItemDto)
        //{
        //    //How do i make sure entity framework manages the foodItemId automatically.
        //    var foodItem = new FoodItem(
        //        foodItemDto.Description,
        //        foodItemDto.UnitPrice.Value
        //    );

        //    _context.FoodItems.Add(foodItem);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFoodItem", new { id = foodItem.FoodItemId }, foodItemDto);
        //} //I forgot I had already created a new POST method xd

        //POST: api/AddFoodItems(name, )
        [HttpPost("AddFoodItem")]
        public async Task<ActionResult<FoodItemDto>> AddFoodItem(FoodItemDto foodItemDto)
        {
            // Map the DTO to the entity
            var foodItem = new FoodItem();
            // Check if Description is provided and not empty
            if (!string.IsNullOrEmpty(foodItemDto.Description))
            {
                foodItem.Description = foodItemDto.Description;
            }

            // Check if UnitPrice is provided and has a valid value
            if (foodItemDto.UnitPrice.HasValue)
            {
                foodItem.UnitPrice = foodItemDto.UnitPrice.Value;
            }

            _context.FoodItems.Add(foodItem);
            await _context.SaveChangesAsync();

            //might want to use CreatedAtAction(nameof(GetFoodItem), ...) instead of hardcoding the action name "GetSession",
            //which is generally safer if you ever rename or refactor the action later.
            // Reference an existing action that retrieves a FoodItem by ID (e.g., GetFoodItem)
            return CreatedAtAction(nameof(GetFoodItem), new {id = foodItem.FoodItemId}, foodItemDto);
        }

        // DELETE: api/FoodItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodItem(int id)
        {
            var foodItem = await _context.FoodItems.FindAsync(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            try
            {
                _context.FoodItems.Remove(foodItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        private bool FoodItemExists(int id)
        {
            return _context.FoodItems.Any(e => e.FoodItemId == id);
        }
    }
}
