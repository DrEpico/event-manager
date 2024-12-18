﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.EventList
{
    public class DeleteModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DeleteModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectedEvent = await _context.Events.FirstOrDefaultAsync(m => m.EventId == id);

            if (selectedEvent == null)
            {
                return NotFound();
            }
            else
            {
                Event = selectedEvent;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectedEvent = await _context.Events.FindAsync(id);
            if (selectedEvent != null)
            {
                Event = selectedEvent;
                _context.Events.Remove(Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
