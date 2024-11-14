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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodItem>>> GetFoodItems()
        {
            return await _context.FoodItems.ToListAsync();
        }

        // GET: api/FoodItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodItem>> GetFoodItem(int id)
        {
            var foodItem = await _context.FoodItems.FindAsync(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            return foodItem;
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
            foodItem.Description = foodItemDto.Description;
            foodItem.UnitPrice = foodItemDto.UnitPrice;

            // Save the changes to the database
            await _context.SaveChangesAsync();

            // Return a NoContent response to indicate a successful update
            return NoContent();
        }

        // POST: api/FoodItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodItem>> PostFoodItem(FoodItem foodItem)
        {
            _context.FoodItems.Add(foodItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodItem", new { id = foodItem.FoodItemId }, foodItem);
        }

        //POST: api/AddFoodItems(name, )
        [HttpPost("AddFoodItem")]
        public async Task<ActionResult<FoodItemDto>> AddFoodItem(FoodItemDto foodItemDto)
        {
            // Map the DTO to the entity
            var foodItem = new FoodItem()
            {
                Description = foodItemDto.Description,
                UnitPrice = foodItemDto.UnitPrice
            };

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

            _context.FoodItems.Remove(foodItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodItemExists(int id)
        {
            return _context.FoodItems.Any(e => e.FoodItemId == id);
        }
    }
}
