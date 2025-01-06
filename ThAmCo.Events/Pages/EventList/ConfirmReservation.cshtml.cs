using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThAmCo.Events.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace ThAmCo.Events.Pages.EventList
{
    [Authorize(Policy = "EmployeeAccess")]
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
