using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using ThAmCo.Events.ViewModels;

namespace ThAmCo.Events.Pages.GuestList
{
    public class IndexModel : PageModel
    {
        private readonly EventDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(EventDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<GuestViewModel> Guests { get; set; } = new List<GuestViewModel>();

        [TempData]
        public string? StatusMessage { get; set; }

        public async Task OnGetAsync()
        {
            var guests = await _context.Guests
                .Include(g => g.GuestBookings)
                .ThenInclude(gb => gb.Event)
                .ToListAsync();

            Guests = guests.Select(g => new GuestViewModel
            {
                GuestId = g.GuestId,
                Name = g.Name,
                Email = g.Email,
                Phone = g.Phone,
                Bookings = g.GuestBookings.Select(gb => new GuestViewModel.GuestBookingSummary
                {
                    EventId = gb.EventId,
                    EventTitle = gb.Event?.Title ?? "Unknown Event",
                    EventDate = gb.Event?.Date ?? DateTime.MinValue,
                    HasAttended = gb.HasAttended,
                    IsCancelled = gb.IsCancelled
                }).ToList()
            }).ToList();
        }
    }
}