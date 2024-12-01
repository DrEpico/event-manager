using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }
        public string EventType { get; set; }
        public string? VenueCode { get; set; } // Bind the selected venue's code

        // Navigation Properties
        public List<GuestBooking> GuestBookings { get; set; } = new();
        public List<Staffing> Staffings { get; set; } = new();
    }
}
