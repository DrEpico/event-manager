using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class GuestBooking
    {
        public int GuestBookingId { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }

        [Display(Name = "Attended")]
        public bool HasAttended { get; set; }

        [Display(Name = "Cancelled")]
        public bool IsCancelled { get; set; }

        // Navigation Properties
        public Guest? Guest { get; set; }
        public Event? Event { get; set; }
    }
}
