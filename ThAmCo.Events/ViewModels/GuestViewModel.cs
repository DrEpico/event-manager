using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.ViewModels
{
    public class GuestViewModel
    {
        public int GuestId { get; set; }

        [Required(ErrorMessage = "Guest name is required")]
        [Display(Name = "Guest Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        [StringLength(256, ErrorMessage = "Email cannot exceed 256 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Phone number must be between 5 and 20 characters")]
        public string Phone { get; set; } = string.Empty;

        // Simplified version of bookings for display
        public List<GuestBookingSummary> Bookings { get; set; } = new();

        public class GuestBookingSummary
        {
            public int EventId { get; set; }
            public string EventTitle { get; set; } = string.Empty;
            public DateTime EventDate { get; set; }
            public bool HasAttended { get; set; }
            public bool IsCancelled { get; set; }
        }
    }
}
