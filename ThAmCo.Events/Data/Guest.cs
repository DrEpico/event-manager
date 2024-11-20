namespace ThAmCo.Events.Data
{
    public class Guest
    {
        public int GuestId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Navigation Properties
        public List<GuestBooking> GuestBookings { get; set; } = new();
    }
}
