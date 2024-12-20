using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.ViewModels
{
    public class GuestBookingViewModel
    {
        public int GuestBookingId { get; set; }

        [Required(ErrorMessage = "Guest must be selected")]
        [Display(Name = "Guest")]
        public int GuestId { get; set; }

        [Required(ErrorMessage = "Event must be selected")]
        [Display(Name = "Event")]
        public int EventId { get; set; }

        [Display(Name = "Has Attended")]
        public bool HasAttended { get; set; }

        [Display(Name = "Cancelled")]
        public bool IsCancelled { get; set; }

        // Display properties for related entities
        public string GuestName { get; set; } = string.Empty;
        public string GuestEmail { get; set; } = string.Empty;
        public string EventTitle { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
    }
}
