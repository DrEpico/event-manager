using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.EventList
{
    [Authorize(Policy = "EmployeeAccess")]
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
