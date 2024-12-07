using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThAmCo.Events.Dtos;

namespace ThAmCo.Events.Pages.EventList
{
    public class ConfirmationModel : PageModel
    {
        public ConfirmReservationDto ReservationDetails { get; set; }

        public void OnGet(ConfirmReservationDto reservation)
        {
            // Populate reservation details
            ReservationDetails = reservation ?? throw new ArgumentNullException(nameof(reservation));
        }
    }
}
