namespace ThAmCo.Events.Data
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string EventType { get; set; }

        // Navigation Properties
        public List<GuestBooking> GuestBookings { get; set; } = new();
        public List<Staffing> Staffings { get; set; } = new();
    }
}
