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
    public class IndexModel : PageModel
    {
        private readonly EventDbContext _context;

        public IndexModel(EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; } = default!;

        // Fetch all the events from the database.
        public async Task OnGetAsync()
        {
            Event = await _context.Events.ToListAsync();
        }
    }
}
