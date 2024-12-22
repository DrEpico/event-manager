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
    /// API Controller for managing Menus.
    /// </summary>
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
        //[HttpGet("GetMenusFull")]
        //public async Task<ActionResult<IEnumerable<Menu>>> GetMenusFull()
        //{
        //    return await _context.Menus.ToListAsync();
        //}

        // Considering to implement pagination for scalability.
        /// <summary>
        /// Retrieves all Menus with limited details (ID and Name).
        /// GET: api/GetMenus
        /// </summary>
        /// <returns>A list of MenuOutputDto objects.</returns>
        [HttpGet("GetMenus")]
        public async Task<ActionResult<IEnumerable<MenuOutputDto>>> GetMenus()
        {
            try
            {
                // Transform entity list into a DTO list to limit the output fields and protect sensitive data.
                var Menus = await _context.Menus
                    .Select(menu => new MenuOutputDto(menu.MenuId, menu.MenuName))
                    .ToListAsync();

                if (!Menus.Any()) 
                    return NotFound("No Menus found");

                return Ok(Menus);
            } 
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves a specific Menu by its ID.
        /// GET: api/Menus/5
        /// </summary>
        /// <param name="id">The ID of the Menu.</param>
        /// <returns>The Menu as a MenuOutputDto object.</returns>
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
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMenu(int id, Menu menu)
        //{
        //    if (id != menu.MenuId)
        //    {
        //        return BadRequest();
        //    }
        //    _context.Entry(menu).State = EntityState.Modified;
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MenuExists(id))
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
        /// Updates the name of an existing Menu.
        /// PUT: api/Menu/EditName/id
        /// </summary>
        /// <param name="id">The ID of the Menu to update.</param>
        /// <param name="menuDto">The DTO containing the new name for the Menu.</param>
        /// <returns>No content if successful, or an error response.</returns>
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

        /// <summary>
        /// Creates a new Menu.
        /// POST: api/Menus
        /// </summary>
        /// <param name="menuDto">The DTO containing the details for the new Menu.</param>
        /// <returns>A 201 Created response with the created Menu details.</returns>
        [HttpPost]//TODO: Route to the created object
        public async Task<ActionResult> PostMenu(MenuInputDto menuDto)
        {   
            //Delete this if the code below works
            //Menu menu = new Menu
            //{
            //    MenuName = menuDto.MenuName
            //};

            //try
            //{
            //    // Add the new Menu to the database context
            //    _context.Menus.Add(menu);
            //    await _context.SaveChangesAsync();

            //    return CreatedAtAction(nameof(GetMenu), new { id = menu.MenuId }, menuDto);
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(500, $"Internal server error: {ex.Message}");
            //}
            try
            {
                // Map the input DTO to the Menu entity
                var menu = new Menu
                {
                    MenuName = menuDto.MenuName
                };

                // Add the new Menu to the database context
                _context.Menus.Add(menu);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetMenu), new { id = menu.MenuId }, new MenuOutputDto(menu.MenuId, menu.MenuName));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes an existing Menu by its ID.
        /// DELETE: api/Menus/5
        /// </summary>
        /// <param name="id">The ID of the Menu to delete.</param>
        /// <returns>No content if successful, or an error response.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            try
            {
                var menu = await _context.Menus.FindAsync(id);
                if (menu == null)
                    return NotFound("Menu not found.");

                _context.Menus.Remove(menu);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Checks if a Menu exists in the database by its ID.
        /// </summary>
        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.MenuId == id);
        }
    }
}
