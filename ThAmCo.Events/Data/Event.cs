using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class Event
    {
        public int EventId { get; set; }
        [Display(Name = "Event Title", Description = "The title of the event", Prompt = "Enter the event title")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //[DataType(DataType.Time)]
        [Display(Name = "Stard Time")]
        public TimeSpan StartTime { get; set; }

        //[DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }

        [Display(Name = "Event Type")]
        public string EventType { get; set; } = string.Empty;

        // This is a computed property that will return the full event type name
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
            _ => "Unknown Venue"
        };

        public string? VenueReference { get; set; } // Bind the selected venue's code
        public bool IsCancelled { get; set; }

        // Navigation Properties
        public List<GuestBooking> GuestBookings { get; set; } = new();
        public List<Staffing> Staffings { get; set; } = new();
    }
}
