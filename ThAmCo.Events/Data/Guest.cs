namespace ThAmCo.Events.Data
{
    public class Guest
    {
        public int GuestId { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        // Navigation Properties
        public List<GuestBooking> GuestBookings { get; set; } = new();

        public Guest()
        {

        }

        public Guest(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
