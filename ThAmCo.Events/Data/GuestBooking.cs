namespace ThAmCo.Events.Data
{
    public class GuestBooking
    {
        public int GuestBookingId { get; set; }
        public int GuestId { get; set; }
        public int EventId { get; set; }
        public bool HasAttended { get; set; }

        // Navigation Properties
        public Guest Guest { get; set; }
        public Event Event { get; set; }
    }
}
