namespace ThAmCo.Events.Data
{
    public class GuestBooking
    {
        public int GuestBookingId { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
        public bool HasAttended { get; set; }

        // Navigation Properties
        public List<GuestBooking> GuestBookings { get; set; } = new();
        public List<Staffing> Staffings { get; set; } = new();
    }
}
