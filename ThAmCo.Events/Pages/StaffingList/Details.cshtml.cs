﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.StaffingList
{
    public class DetailsModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public DetailsModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        public Staffing Staffing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing = await _context.Staffing.FirstOrDefaultAsync(m => m.StaffingId == id);
            if (staffing == null)
            {
                return NotFound();
            }
            else
            {
                Staffing = staffing;
            }
            return Page();
        }
    }
}