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
    public class MenusController : ControllerBase
    {
        private readonly CateringDbContext _context;

        public MenusController(CateringDbContext context)
        {
            _context = context;
        }

        //Could comment this out?
        // GET: api/GetMenusFull
        [HttpGet("GetMenusFull")]
        public async Task<ActionResult<IEnumerable<Menu>>> GetMenusFull()
        {
            return await _context.Menus.ToListAsync();
        }

        //Consider Pagination for scalability
        // GET: api/GetMenus

        [HttpGet("GetMenus")]
        public async Task<ActionResult<IEnumerable<MenuOutputDto>>> GetMenus()
        {
            try
            {
                // Transform entity list into a DTO list to limit the output fields and protect sensitive data.
                var menus = await _context.Menus
                    .Select(menu => new MenuOutputDto(menu.MenuId, menu.MenuName))
                    .ToListAsync();

                if (!menus.Any()) 
                    return NotFound("No menus found");

                return Ok(menus);
            } 
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuOutputDto>> GetMenu(int id)
        {
            try
            {
                var menu = await _context.Menus.FindAsync(id);

                if (menu == null)
                {
                    return NotFound();
                }

                MenuOutputDto menuDto = new MenuOutputDto(menu.MenuId, menu.MenuName);

                menuDto.MenuId = menu.MenuId;
                menuDto.MenuName = menu.MenuName;

                return menuDto;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.MenuId)
            {
                return BadRequest();
            }

            _context.Entry(menu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(id))
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

        //PUT: api/Menu/EditName/id
        [HttpPut("EditName/{id}")]
        public async Task<IActionResult> EditMenuName(int id, MenuInputDto menuDto)
        {
            var menu = await _context.Menus.FindAsync(id);

            if (menu == null)
            {
                return NotFound();
            }

            try
            {
                menu.MenuName = menuDto.MenuName;
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(MenuInputDto menuDto)
        {
            // Map the input DTO to the Menu entity
            Menu menu = new Menu
            {
                MenuName = menuDto.MenuName
            };

            try
            {
                // Add the new Menu to the database context
                _context.Menus.Add(menu);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetMenu), new { id = menu.MenuId }, menuDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.MenuId == id);
        }
    }
}
