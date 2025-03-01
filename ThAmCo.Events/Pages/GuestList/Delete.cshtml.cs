﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using Microsoft.AspNetCore.Authorization;

namespace ThAmCo.Events.Pages.GuestList
{
    [Authorize(Policy = "ElevatedAccess")]
    public class DeleteModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DeleteModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Guest Guest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Find the guest with the given ID.
            var guest = await _context.Guests.FirstOrDefaultAsync(m => m.GuestId == id);

            if (guest == null)
            {
                return NotFound();
            }
            else
            {
                Guest = guest;
            }
            return Page();
        }

        /// <summary>
        /// Removes the guest record from the database.
        /// </summary>
        /// <param name="id">ID of the guest.</param>
        /// <returns>Redirect to the guest list page</returns>
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                Guest = guest;
                _context.Guests.Remove(Guest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
