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
    /// Controller for managing food items in the catering system.
    /// </summary>
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
        //[HttpGet("GetFoodItemsFull")]
        //public async Task<ActionResult<IEnumerable<FoodItem>>> GetFoodItemsFull()
        //{
        //    return await _context.FoodItems.ToListAsync();
        //}

        /// <summary>
        /// Retrieves all food items with their descriptions and prices.
        /// </summary>
        /// <returns>A list of food items in the form of DTOs.</returns>
        [HttpGet("GetFoodItems")]
        public async Task<ActionResult<IEnumerable<FoodItemDto>>> GetFoodItems()
        {
            try
            {
                // Fetch and map FoodItems to DTOs
                var FoodItems = await _context.FoodItems
                    .Select(fi => new FoodItemDto(fi.Description, fi.UnitPrice))
                    .ToListAsync();

                // Return a 404 status if no food items exist
                if (!FoodItems.Any())
                    return NotFound("No item found");

                return Ok(FoodItems);
            }
            catch (Exception ex)
            {
                // Handle server errors
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves a specific food item by its ID.
        /// GET: api/FoodItems/5
        /// </summary>
        /// <param name="id">The ID of the food item to retrieve.</param>
        /// <returns>The requested food item as a DTO.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodItemDto>> GetFoodItem(int id)
        {
            // Find the food item by its ID
            var foodItem = await _context.FoodItems.FindAsync(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            // Map the entity to a DTO
            var foodItemDto = new FoodItemDto();
            foodItemDto.Description = foodItem.Description;
            foodItemDto.UnitPrice = foodItem.UnitPrice;

            return foodItemDto;
        }

        // PUT: api/FoodItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFoodItem(int id, FoodItem foodItem)
        //{
        //    if (id != foodItem.FoodItemId)
        //    {
        //        return BadRequest();
        //    }
        //    _context.Entry(foodItem).State = EntityState.Modified;
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FoodItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return NoContent();
        //}

        /// <summary>
        /// Updates an existing food item by its ID.
        /// PUT: api/EditFoodItem/{id}
        /// </summary>
        /// <param name="id">The ID of the food item to update.</param>
        /// <param name="foodItemDto">The updated food item data.</param>
        /// <returns>No content if the update is successful.</returns>
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

        /// <summary>
        /// Adds a new food item.
        /// POST: api/AddFoodItems
        /// </summary>
        /// <param name="foodItemDto">The food item data to add.</param>
        /// <returns>The created food item as a DTO.</returns>
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

        /// <summary>
        /// Deletes a food item by its ID.
        /// DELETE: api/FoodItems/5
        /// </summary>
        /// <param name="id">The ID of the food item to delete.</param>
        /// <returns>No content if the deletion is successful.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodItem(int id)
        {
            // Find the food item by its ID
            var foodItem = await _context.FoodItems.FindAsync(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            try
            {
                // Remove the food item
                _context.FoodItems.Remove(foodItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle server errors
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        /// <summary>
        /// Checks if a food item exists by its ID.
        /// </summary>
        /// <param name="id">The ID of the food item.</param>
        /// <returns>True if the food item exists; otherwise, false.</returns>
        private bool FoodItemExists(int id)
        {
            return _context.FoodItems.Any(e => e.FoodItemId == id);
        }
    }
}
