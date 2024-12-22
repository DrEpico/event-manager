using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Pages.GuestList
{
    public class EditModel : PageModel
    {
        private readonly ThAmCo.Events.Data.EventDbContext _context;

        public EditModel(ThAmCo.Events.Data.EventDbContext context)
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

            var guest =  await _context.Guests.FirstOrDefaultAsync(m => m.GuestId == id);
            if (guest == null)
            {
                return NotFound();
            }
            Guest = guest;
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

            _context.Attach(Guest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestExists(Guest.GuestId))
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

        private bool GuestExists(int id)
        {
            return _context.Guests.Any(e => e.GuestId == id);
        }

        public async Task<IActionResult> OnPostAnonymiseGuest(int GuestId)
        {
            var guest = await _context.Guests.FirstOrDefaultAsync(g => g.GuestId == GuestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found");
                return Page();
            }

            string anon = GenerateAnon();

            if (anon != null)
            {
                guest.Name = anon;
                guest.Email = anon + guest.GuestId.ToString() + "@removed.com";
                guest.Phone = "0000000000";
                //TODO?: Could also remove the guest bookings?
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save anonymised guest information: {ex.Message}");
            }

            return Page();
        }

        private string GenerateAnon()
        {
            var anon = "anon";
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int num = random.Next(0, 9);
                num.ToString();
                anon += num.ToString();
            }
            return anon;
        }
    }
}
