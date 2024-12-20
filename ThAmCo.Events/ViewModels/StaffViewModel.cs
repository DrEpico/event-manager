using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.ViewModels
{
    public class StaffViewModel
    {
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Staff name is required")]
        [Display(Name = "Staff Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Staff role is required")]
        [Display(Name = "Staff Role")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Role must be between 2 and 50 characters")]
        public string Role { get; set; } = string.Empty;

        // You might want to include a simplified version of staffing information
        public List<StaffingBasicInfo> Assignments { get; set; } = new();

        // Helper class for simplified staffing information
        public class StaffingBasicInfo
        {
            public int EventId { get; set; }
            public string EventTitle { get; set; } = string.Empty;
            public DateTime EventDate { get; set; }
        }
    }
}
