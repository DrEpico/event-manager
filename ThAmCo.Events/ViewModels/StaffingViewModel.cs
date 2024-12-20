using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.ViewModels
{
    public class StaffingViewModel
    {
        public int StaffingId { get; set; }
        
        [Required(ErrorMessage = "Staff member must be selected")]
        [Display(Name = "Staff Member")]
        public int StaffId { get; set; }
        
        [Required(ErrorMessage = "Event must be selected")]
        [Display(Name = "Event")]
        public int EventId { get; set; }

        // Navigation Properties
        public Staff Staff { get; set; } 
        public Event Event { get; set; }

        // Display properties for related entities
        public string StaffName { get; set; } = string.Empty;
        public string EventTitle { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
    }
}
