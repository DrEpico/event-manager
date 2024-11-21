﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.GuestBookingList
{
    public class IndexModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public IndexModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        public IList<GuestBooking> GuestBooking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            GuestBooking = await _context.GuestBookings
                .Include(g => g.Event)
                .Include(g => g.Guest).ToListAsync();
        }
    }
}