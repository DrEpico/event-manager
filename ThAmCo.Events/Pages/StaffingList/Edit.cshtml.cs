﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.StaffingList
{
    public class EditModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public EditModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staffing Staffing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing =  await _context.Staffing.FirstOrDefaultAsync(m => m.StaffingId == id);
            if (staffing == null)
            {
                return NotFound();
            }
            Staffing = staffing;
           ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
           ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "StaffId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Staffing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffingExists(Staffing.StaffingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StaffingExists(int id)
        {
            return _context.Staffing.Any(e => e.StaffingId == id);
        }
    }
}