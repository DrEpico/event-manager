using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using Microsoft.AspNetCore.Authorization;

namespace ThAmCo.Events.Pages.StaffList
{
    [Authorize(Policy = "EmployeeAccess")]
    public class IndexModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public IndexModel(ThAmCo.Events.Data.EventDbContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
