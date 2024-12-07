using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestBooking> GuestBookings { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public string DbPath { get; set; } = string.Empty;

        public EventDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ThAmCo.Event.db");
            //Console.WriteLine($"Database Path: {DbPath}");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Event>()
                .Property(e => e.EndTime)
                .HasConversion(
                    v => v.ToString(), // Convert TimeSpan to string for storage
                    v => TimeSpan.Parse(v) // Convert string back to TimeSpan
                );
            modelBuilder.Entity<Event>()
                .Property(e => e.StartTime)
                .HasConversion(
                    v => v.ToString(), // Convert TimeSpan to string for storage
                    v => TimeSpan.Parse(v) // Convert string back to TimeSpan
                );

            modelBuilder.Entity<Event>().HasData(
                new Event { EventId = 1, Title = "Tech Expo", Date = new DateTime(2024, 12, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), EventType = "Exhibition" },
                new Event { EventId = 2, Title = "AI Workshop", Date = new DateTime(2024, 12, 3), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(15, 0, 0), EventType = "Workshop" },
                new Event { EventId = 3, Title = "Annual Gala Dinner", Date = new DateTime(2024, 12, 5), StartTime = new TimeSpan(19, 0, 0), EndTime = new TimeSpan(23, 0, 0), EventType = "Gala" },
                new Event { EventId = 4, Title = "Coding Hackathon", Date = new DateTime(2024, 12, 6), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0), EventType = "Competition" },
                new Event { EventId = 5, Title = "Marketing Summit", Date = new DateTime(2024, 12, 8), StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(16, 30, 0), EventType = "Conference" },
                new Event { EventId = 6, Title = "Startup Pitch Fest", Date = new DateTime(2024, 12, 10), StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(20, 0, 0), EventType = "Competition" },
                new Event { EventId = 7, Title = "Science Fair", Date = new DateTime(2024, 12, 12), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(16, 0, 0), EventType = "Exhibition" },
                new Event { EventId = 8, Title = "Charity Auction", Date = new DateTime(2024, 12, 14), StartTime = new TimeSpan(18, 0, 0), EndTime = new TimeSpan(22, 0, 0), EventType = "Fundraiser" },
                new Event { EventId = 9, Title = "Photography Workshop", Date = new DateTime(2024, 12, 15), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(17, 0, 0), EventType = "Workshop" },
                new Event { EventId = 10, Title = "Art & Design Expo", Date = new DateTime(2024, 12, 18), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(18, 0, 0), EventType = "Exhibition" },
                new Event { EventId = 11, Title = "Developer Meetup", Date = new DateTime(2024, 12, 20), StartTime = new TimeSpan(19, 0, 0), EndTime = new TimeSpan(21, 30, 0), EventType = "Networking" },
                new Event { EventId = 12, Title = "Community Volunteering", Date = new DateTime(2024, 12, 22), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(15, 0, 0), EventType = "Outreach" },
                new Event { EventId = 13, Title = "Holiday Festival", Date = new DateTime(2024, 12, 24), StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(22, 0, 0), EventType = "Festival" },
                new Event { EventId = 14, Title = "Leadership Seminar", Date = new DateTime(2024, 12, 26), StartTime = new TimeSpan(9, 30, 0), EndTime = new TimeSpan(16, 30, 0), EventType = "Workshop" },
                new Event { EventId = 15, Title = "End-of-Year Party", Date = new DateTime(2024, 12, 30), StartTime = new TimeSpan(20, 0, 0), EndTime = new TimeSpan(23, 59, 0), EventType = "Festival" }
            );

            // Seed data for Guests
            modelBuilder.Entity<Guest>().HasData(
                new Guest { GuestId = 1, Name = "Alice Johnson", Email = "alice.johnson@example.com", Phone = "1234567890" },
                new Guest { GuestId = 2, Name = "Bob Smith", Email = "bob.smith@example.com", Phone = "2345678901" },
                new Guest { GuestId = 3, Name = "Charlie Brown", Email = "charlie.brown@example.com", Phone = "3456789012" },
                new Guest { GuestId = 4, Name = "Diana Prince", Email = "diana.prince@example.com", Phone = "4567890123" },
                new Guest { GuestId = 5, Name = "Eve Adams", Email = "eve.adams@example.com", Phone = "5678901234" },
                new Guest { GuestId = 6, Name = "Frank Harris", Email = "frank.harris@example.com", Phone = "6789012345" },
                new Guest { GuestId = 7, Name = "Grace Lee", Email = "grace.lee@example.com", Phone = "7890123456" },
                new Guest { GuestId = 8, Name = "Hank Hill", Email = "hank.hill@example.com", Phone = "8901234567" },
                new Guest { GuestId = 9, Name = "Ivy Nguyen", Email = "ivy.nguyen@example.com", Phone = "9012345678" },
                new Guest { GuestId = 10, Name = "Jack Miller", Email = "jack.miller@example.com", Phone = "0123456789" },
                new Guest { GuestId = 11, Name = "Kelly Green", Email = "kelly.green@example.com", Phone = "1122334455" },
                new Guest { GuestId = 12, Name = "Luke Skywalker", Email = "luke.skywalker@example.com", Phone = "2233445566" },
                new Guest { GuestId = 13, Name = "Maria Garcia", Email = "maria.garcia@example.com", Phone = "3344556677" },
                new Guest { GuestId = 14, Name = "Nathan Drake", Email = "nathan.drake@example.com", Phone = "4455667788" },
                new Guest { GuestId = 15, Name = "Olivia King", Email = "olivia.king@example.com", Phone = "5566778899" }
            );

            // Seed data for GuestBookings
            modelBuilder.Entity<GuestBooking>().HasData(
                new GuestBooking { GuestBookingId = 1, GuestId = 1, EventId = 1, HasAttended = false },
                new GuestBooking { GuestBookingId = 2, GuestId = 2, EventId = 2, HasAttended = true },
                new GuestBooking { GuestBookingId = 3, GuestId = 3, EventId = 3, HasAttended = false },
                new GuestBooking { GuestBookingId = 4, GuestId = 4, EventId = 4, HasAttended = true },
                new GuestBooking { GuestBookingId = 5, GuestId = 5, EventId = 5, HasAttended = false },
                new GuestBooking { GuestBookingId = 6, GuestId = 6, EventId = 6, HasAttended = true },
                new GuestBooking { GuestBookingId = 7, GuestId = 7, EventId = 7, HasAttended = false },
                new GuestBooking { GuestBookingId = 8, GuestId = 8, EventId = 8, HasAttended = true },
                new GuestBooking { GuestBookingId = 9, GuestId = 9, EventId = 9, HasAttended = false },
                new GuestBooking { GuestBookingId = 10, GuestId = 10, EventId = 10, HasAttended = true },
                new GuestBooking { GuestBookingId = 11, GuestId = 11, EventId = 11, HasAttended = false },
                new GuestBooking { GuestBookingId = 12, GuestId = 12, EventId = 12, HasAttended = true },
                new GuestBooking { GuestBookingId = 13, GuestId = 13, EventId = 13, HasAttended = false },
                new GuestBooking { GuestBookingId = 14, GuestId = 14, EventId = 14, HasAttended = true },
                new GuestBooking { GuestBookingId = 15, GuestId = 15, EventId = 15, HasAttended = false },
                new GuestBooking { GuestBookingId = 16, GuestId = 15, EventId = 1, HasAttended = true },
                new GuestBooking { GuestBookingId = 17, GuestId = 15, EventId = 2, HasAttended = true },
                new GuestBooking { GuestBookingId = 18, GuestId = 1, EventId = 15, HasAttended = true }
            );

            modelBuilder.Entity<Staff>().HasData(
                new Staff { StaffId = 1, Name = "Anna White", Role = "Coordinator" },
                new Staff { StaffId = 2, Name = "Ben Thomas", Role = "Manager" },
                new Staff { StaffId = 3, Name = "Cathy Holmes", Role = "Assistant" },
                new Staff { StaffId = 4, Name = "David Chen", Role = "Coordinator" },
                new Staff { StaffId = 5, Name = "Emily Brown", Role = "Manager" },
                new Staff { StaffId = 6, Name = "Fred Johnson", Role = "Assistant" },
                new Staff { StaffId = 7, Name = "George Lee", Role = "Coordinator" },
                new Staff { StaffId = 8, Name = "Helen Davis", Role = "Manager" },
                new Staff { StaffId = 9, Name = "Irene Scott", Role = "Assistant" },
                new Staff { StaffId = 10, Name = "Jackie Ray", Role = "Coordinator" },
                new Staff { StaffId = 11, Name = "Kevin Moore", Role = "Manager" },
                new Staff { StaffId = 12, Name = "Lily Green", Role = "Assistant" },
                new Staff { StaffId = 13, Name = "Mike Taylor", Role = "Coordinator" },
                new Staff { StaffId = 14, Name = "Nina Brooks", Role = "Manager" },
                new Staff { StaffId = 15, Name = "Oscar Peterson", Role = "Assistant" },
                new Staff { StaffId = 16, Name = "Patricia Ward", Role = "Coordinator" },
                new Staff { StaffId = 17, Name = "Quincy Adams", Role = "Manager" },
                new Staff { StaffId = 18, Name = "Rachel King", Role = "Assistant" },
                new Staff { StaffId = 19, Name = "Samuel Turner", Role = "Coordinator" },
                new Staff { StaffId = 20, Name = "Tina Evans", Role = "Manager" },
                new Staff { StaffId = 21, Name = "Uma Patel", Role = "Assistant" },
                new Staff { StaffId = 22, Name = "Victor Stone", Role = "Coordinator" },
                new Staff { StaffId = 23, Name = "Wendy Clark", Role = "Manager" },
                new Staff { StaffId = 24, Name = "Xavier Lewis", Role = "Assistant" },
                new Staff { StaffId = 25, Name = "Yvonne Carter", Role = "Coordinator" }
            );

        }
        public DbSet<ThAmCo.Events.Data.Staffing> Staffing { get; set; } = default!;
    }
}
