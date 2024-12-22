using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Text;
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
    /// Controller for managing the relationships between menus and food items (MenuFoodItems).
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MenuFoodItemsController : ControllerBase
    {
        private readonly CateringDbContext _context;

        public MenuFoodItemsController(CateringDbContext context)
        {
            _context = context;
        }

        // GET: api/MenuFoodItems
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<MenuFoodItem>>> GetMenuFoodItems()
        //{
        //    return await _context.MenuFoodItems.ToListAsync();
        //}

        /// <summary>
        /// Retrieves all MenuFoodItem records, including related menu names and food item descriptions.
        /// GET: api/MenuFoodItems
        /// </summary>
        /// <returns>A list of MenuFoodItem DTOs.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuFoodItemDto>>> GetMenuFoodItems()
        {   
            // Include related data for proper projection
            var menuFoodItems = await _context.MenuFoodItems
                .Include(mfi => mfi.Menu)
                .Include(mfi => mfi.FoodItem)
                .ToListAsync();

            // Map entities to DTOs with null-checks
            var menuFoodItemsDto = menuFoodItems
                .Select(mfi => new MenuFoodItemDto(
                    mfi.Menu?.MenuName ?? "Unknown menu",
                    mfi.FoodItem?.Description ?? "Unknown item"))
                .ToList();

            return Ok(menuFoodItemsDto);
        }

        // Skipping individual composite key lookup as it's not typical for this use case.
        /// <summary>
        /// Retrieves a specific MenuFoodItem record by ID.
        /// GET: api/MenuFoodItems/5
        /// </summary>
        /// <param name="id">The ID of the MenuFoodItem record.</param>
        /// <returns>The MenuFoodItem record.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuFoodItem>> GetMenuFoodItem(int id)
        {
            var menuFoodItem = await _context.MenuFoodItems.FindAsync(id);

            if (menuFoodItem == null)
            {
                return NotFound();
            }

            return menuFoodItem;
        }

        // Editing a composite table record is not required per your note, so this is skipped.
        /// <summary>
        /// Updates an existing MenuFoodItem record.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuFoodItem(int id, MenuFoodItem menuFoodItem)
        {
            if (id != menuFoodItem.MenuId)
            {
                return BadRequest();
            }

            _context.Entry(menuFoodItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuFoodItemExists(id))
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

        /// <summary>
        /// Adds a new MenuFoodItem record linking a menu and a food item.
        /// POST: api/MenuFoodItems
        /// </summary>
        /// <param name="menuId">The menu to be added with an item</param>
        /// <param name="itemId">The food item to be added to the specificed menu</param>
        /// <returns>201 Created Status Code </returns>
        [HttpPost("CreateMenuFoodItem")]
        public async Task<ActionResult> PostMenuFoodItem(int menuId, int itemId)
        {
            // Ensure both menu and food item exist
            var menu = await _context.Menus.FindAsync(menuId);
            var item = await _context.FoodItems.FindAsync(itemId);

            // Create a new MenuFoodItem
            var MenuFoodItem = new MenuFoodItem(menuId, itemId);
            _context.MenuFoodItems.Add(MenuFoodItem);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException)
            {
                if(MenuHasFoodItem(menuId, itemId))
                {
                    return Conflict();
                } 
                else
                {
                    throw;
                }
            }

            return Created(); //Probably return a list of items on the modificated menu.
        }

        /// <summary>
        /// Deletes a MenuFoodItem record, unlinking a food item from a menu.
        /// DELETE: api/MenuFoodItems/5
        /// </summary>
        /// <param name="menuId">The ID of the menu.</param>
        /// <param name="itemId">The ID of the food item.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("RemoveMenuFoodItem")]
        public async Task<IActionResult> DeleteMenuFoodItem(int menuId, int itemId)
        {
            // Ensure both menu and food item exist
            var menu = await _context.Menus.FindAsync(menuId);
            var item = await _context.FoodItems.FindAsync(itemId);

            MenuFoodItem MenuFoodItem = new MenuFoodItem(menuId, itemId);

            if (menu == null || item == null)
            {
                return NotFound();
            }

            try
            {
                _context.MenuFoodItems.Remove(MenuFoodItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        /// <summary>
        /// Checks if a MenuFoodItem exists by its MenuId.
        /// </summary>
        private bool MenuFoodItemExists(int id)
        {
            return _context.MenuFoodItems.Any(e => e.MenuId == id);
        }

        /// <summary>
        /// Checks if a menu already has the specified food item.
        /// </summary>
        private bool MenuHasFoodItem(int menuId, int itemId)
        {
            return _context.MenuFoodItems.Any(e => e.MenuId == menuId && e.FoodItemId == itemId);
        }
    }
}
