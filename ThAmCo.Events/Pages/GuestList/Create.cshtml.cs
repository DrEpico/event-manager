using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThAmCo.Events.Data;
using ThAmCo.Events.ViewModels;

namespace ThAmCo.Events.Pages.GuestList
{
    public class CreateModel : PageModel
    {
        private readonly EventDbContext _context;

        public CreateModel(EventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GuestViewModel GuestVM { get; set; } = new GuestViewModel();

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Guest Guest { get; set; } = default!;

        /// <summary>
        /// Save the guest record to the database.
        /// </summary>
        /// <returns>Redirect to the guest list page.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Map view model to data model
            var guest = new Guest
            {
                Name = GuestVM.Name,
                Email = GuestVM.Email,
                Phone = GuestVM.Phone
            };

            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Guest created successfully!";
            return RedirectToPage("./Index");
        }
    }
}