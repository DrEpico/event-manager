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

        // GET: api/MenuFoodItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuFoodItemDto>>> GetMenuFoodItems()
        {   
            // Include related data for proper projection
            var menuFoodItems = await _context.MenuFoodItems
                .Include(mfi => mfi.Menu)
                .Include(mfi => mfi.FoodItem)
                .ToListAsync();

            // Map entities to DTO with null-checks in memory
            var menuFoodItemsDto = menuFoodItems
                .Select(mfi => new MenuFoodItemDto(
                    mfi.Menu != null ? mfi.Menu.MenuName : "Unknown menu",
                    mfi.FoodItem != null ? mfi.FoodItem.Description : "Unknown item"
                ))// Null checks are done in C# instead of being translated to SQL.
                .ToList();

            return Ok(menuFoodItemsDto);
        }

        // GET: api/MenuFoodItems/5
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

        // PUT: api/MenuFoodItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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

        // POST: api/MenuFoodItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MenuFoodItem>> PostMenuFoodItem(int menuId, int itemId)
        {
            var menu = await _context.Menus.FindAsync(menuId);
            var item = await _context.FoodItems.FindAsync(itemId);

            MenuFoodItem MenuFoodItem = new MenuFoodItem(menuId, itemId);
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

            return Created();
        }

        // DELETE: api/MenuFoodItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuFoodItem(int id)
        {
            var menuFoodItem = await _context.MenuFoodItems.FindAsync(id);
            if (menuFoodItem == null)
            {
                return NotFound();
            }

            _context.MenuFoodItems.Remove(menuFoodItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuFoodItemExists(int id)
        {
            return _context.MenuFoodItems.Any(e => e.MenuId == id);
        }

        private bool MenuHasFoodItem(int menuId, int itemId)
        {
            return _context.MenuFoodItems.Any(e => e.MenuId == menuId && e.FoodItemId == itemId);
        }
    }
}
