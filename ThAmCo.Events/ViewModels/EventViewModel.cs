using System.ComponentModel.DataAnnotations;

public class EventViewModel
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Event title is required")]
    [Display(Name = "Event Title")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 100 characters")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event date is required")]
    [Display(Name = "Event Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Start time is required")]
    [Display(Name = "Start Time")]
    [DataType(DataType.Time)]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    public TimeSpan StartTime { get; set; }

    [Required(ErrorMessage = "End time is required")]
    [Display(Name = "End Time")]
    [DataType(DataType.Time)]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    public TimeSpan EndTime { get; set; }

    [Required(ErrorMessage = "Event type is required")]
    [Display(Name = "Event Type")]
    [StringLength(3, MinimumLength = 3, ErrorMessage = "Event type must be 3 characters")]
    public string EventType { get; set; } = string.Empty;

    [Display(Name = "Event Type")]
    public string EventTypeFull => EventType switch
    {
        "CMP" => "Competition",
        "EXH" => "Exhibition",
        "FES" => "Festival",
        "FND" => "Fundraiser",
        "GAL" => "Gala",
        "NET" => "Networking",
        "OTR" => "Outreach",
        "WKS" => "Workshop",
        _ => "Unknown Event Type"
    };

    [Required(ErrorMessage = "Venue reference is required")]
    [Display(Name = "Venue")]
    public string VenueReference { get; set; } = string.Empty;

    [Display(Name = "Cancelled")]
    public bool IsCancelled { get; set; }

    // Summary properties for related entities
    public List<GuestBookingSummary> Bookings { get; set; } = new();
    public List<StaffingSummary> StaffAssignments { get; set; } = new();

    // Nested classes for simplified related data
    public class GuestBookingSummary
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public string GuestEmail { get; set; } = string.Empty;
        public bool HasAttended { get; set; }
        public bool IsCancelled { get; set; }
    }

    public class StaffingSummary
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;
        public string StaffRole { get; set; } = string.Empty;
    }

    // Additional properties for display/validation
    [Display(Name = "Total Guests")]
    public int TotalGuests => Bookings.Count;

    [Display(Name = "Confirmed Guests")]
    public int ConfirmedGuests => Bookings.Count(b => !b.IsCancelled);

    [Display(Name = "Staff Assigned")]
    public int TotalStaffAssigned => StaffAssignments.Count;

    // Custom validation method for time range
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (EndTime <= StartTime)
        {
            yield return new ValidationResult(
                "End time must be after start time",
                new[] { nameof(EndTime) }
            );
        }

        if (Date.Date < DateTime.Now.Date)
        {
            yield return new ValidationResult(
                "Event date cannot be in the past",
                new[] { nameof(Date) }
            );
        }
    }
}
