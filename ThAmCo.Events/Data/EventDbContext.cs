using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ThAmCo.Events.Data
{
    public class EventDbContext : IdentityDbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestBooking> GuestBookings { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Staffing> Staffing { get; set; }
        public string DbPath { get; set; } = string.Empty;

        public EventDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ThAmCo.Event.db");
            //Console.WriteLine($"Database Path: {DbPath}"); //Debugging
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
                //The first event is supposed to show "Failed to fetch" for Venue data.
                //No.2-15 are supposed to show "Unreserved" for Venue data.
                new Event { EventId = 1, Title = "Tech Expo", Date = new DateTime(2025, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), EventType = "EXH", VenueReference = "Test" },
                new Event { EventId = 2, Title = "AI Workshop", Date = new DateTime(2025, 1, 3), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(15, 0, 0), EventType = "WKS" },
                new Event { EventId = 3, Title = "Annual Gala Dinner", Date = new DateTime(2025, 1, 5), StartTime = new TimeSpan(19, 0, 0), EndTime = new TimeSpan(23, 0, 0), EventType = "GAL" },
                new Event { EventId = 4, Title = "Coding Hackathon", Date = new DateTime(2025, 1, 6), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0), EventType = "CMP" },
                new Event { EventId = 5, Title = "Marketing Summit", Date = new DateTime(2024, 12, 8), StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(16, 30, 0), EventType = "OTR" },
                new Event { EventId = 6, Title = "Startup Pitch Fest", Date = new DateTime(2025, 1, 10), StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(20, 0, 0), EventType = "CMP" },
                new Event { EventId = 7, Title = "Science Fair", Date = new DateTime(2025, 1, 12), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(16, 0, 0), EventType = "EXH" },
                new Event { EventId = 8, Title = "Charity Auction", Date = new DateTime(2025, 2, 14), StartTime = new TimeSpan(18, 0, 0), EndTime = new TimeSpan(22, 0, 0), EventType = "FND" },
                new Event { EventId = 9, Title = "Photography Workshop", Date = new DateTime(2025, 2, 15), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(17, 0, 0), EventType = "WKS" },
                new Event { EventId = 10, Title = "Art & Design Expo", Date = new DateTime(2025, 1, 18), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(18, 0, 0), EventType = "EXH" },
                new Event { EventId = 11, Title = "Developer Meetup", Date = new DateTime(2025, 1, 20), StartTime = new TimeSpan(19, 0, 0), EndTime = new TimeSpan(21, 30, 0), EventType = "NET" },
                new Event { EventId = 12, Title = "Community Volunteering", Date = new DateTime(2025, 2, 22), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(15, 0, 0), EventType = "OTR" },
                new Event { EventId = 13, Title = "Holiday Festival", Date = new DateTime(2025, 1, 24), StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(22, 0, 0), EventType = "FES" },
                new Event { EventId = 14, Title = "Leadership Seminar", Date = new DateTime(2025, 2, 26), StartTime = new TimeSpan(9, 30, 0), EndTime = new TimeSpan(16, 30, 0), EventType = "WKS" },
                new Event { EventId = 15, Title = "End-of-Year Party", Date = new DateTime(2024, 12, 30), StartTime = new TimeSpan(20, 0, 0), EndTime = new TimeSpan(23, 59, 0), EventType = "FES" }
            );

            // Seed data for Guests
            modelBuilder.Entity<Guest>().HasData(
                new Guest { GuestId = 1, Name = "Alice Johnson", Email = "alice.johnson@example.com", Phone = "07412345678" },
                new Guest { GuestId = 2, Name = "Bob Smith", Email = "bob.smith@example.com", Phone = "07323456789" },
                new Guest { GuestId = 3, Name = "Charlie Brown", Email = "charlie.brown@example.com", Phone = "07734567890" },
                new Guest { GuestId = 4, Name = "Diana Prince", Email = "diana.prince@example.com", Phone = "07845678901" },
                new Guest { GuestId = 5, Name = "Eve Adams", Email = "eve.adams@example.com", Phone = "07956789012" },
                new Guest { GuestId = 6, Name = "Frank Harris", Email = "frank.harris@example.com", Phone = "07467890123" },
                new Guest { GuestId = 7, Name = "Grace Lee", Email = "grace.lee@example.com", Phone = "07378901234" },
                new Guest { GuestId = 8, Name = "Hank Hill", Email = "hank.hill@example.com", Phone = "07789012345" },
                new Guest { GuestId = 9, Name = "Ivy Nguyen", Email = "ivy.nguyen@example.com", Phone = "07890123456" },
                new Guest { GuestId = 10, Name = "Jack Miller", Email = "jack.miller@example.com", Phone = "07901234567" },
                new Guest { GuestId = 11, Name = "Kelly Green", Email = "kelly.green@example.com", Phone = "07411223344" },
                new Guest { GuestId = 12, Name = "Luke Skywalker", Email = "luke.skywalker@example.com", Phone = "07322334455" },
                new Guest { GuestId = 13, Name = "Maria Garcia", Email = "maria.garcia@example.com", Phone = "07733445566" },
                new Guest { GuestId = 14, Name = "Nathan Drake", Email = "nathan.drake@example.com", Phone = "07844556677" },
                new Guest { GuestId = 15, Name = "Olivia King", Email = "olivia.king@example.com", Phone = "07955667788" },
                new Guest { GuestId = 16, Name = "Paul Walker", Email = "paul.walker@example.com", Phone = "07466778899" },
                new Guest { GuestId = 17, Name = "Quincy Adams", Email = "quincy.adams@example.com", Phone = "07377889900" },
                new Guest { GuestId = 18, Name = "Rachel Scott", Email = "rachel.scott@example.com", Phone = "07788990011" },
                new Guest { GuestId = 19, Name = "Samuel Jackson", Email = "samuel.jackson@example.com", Phone = "07899001122" },
                new Guest { GuestId = 20, Name = "Tina Turner", Email = "tina.turner@example.com", Phone = "07900112233" },
                new Guest { GuestId = 21, Name = "Ulysses Grant", Email = "ulysses.grant@example.com", Phone = "07411223344" },
                new Guest { GuestId = 22, Name = "Victor Hugo", Email = "victor.hugo@example.com", Phone = "07322334455" },
                new Guest { GuestId = 23, Name = "Wendy Darling", Email = "wendy.darling@example.com", Phone = "07733445566" },
                new Guest { GuestId = 24, Name = "Xander Cage", Email = "xander.cage@example.com", Phone = "07844556677" },
                new Guest { GuestId = 25, Name = "Yasmine Lopez", Email = "yasmine.lopez@example.com", Phone = "07955667788" },
                new Guest { GuestId = 26, Name = "Zack Morris", Email = "zack.morris@example.com", Phone = "07466778899" },
                new Guest { GuestId = 27, Name = "Aaron Paul", Email = "aaron.paul@example.com", Phone = "07377889900" },
                new Guest { GuestId = 28, Name = "Beatrice Potter", Email = "beatrice.potter@example.com", Phone = "07788990011" },
                new Guest { GuestId = 29, Name = "Catherine Zeta", Email = "catherine.zeta@example.com", Phone = "07899001122" },
                new Guest { GuestId = 30, Name = "David Beckham", Email = "david.beckham@example.com", Phone = "07900112233" },
                new Guest { GuestId = 31, Name = "Elaine Benes", Email = "elaine.benes@example.com", Phone = "07411223344" },
                new Guest { GuestId = 32, Name = "Freddie Mercury", Email = "freddie.mercury@example.com", Phone = "07322334455" },
                new Guest { GuestId = 33, Name = "George Clooney", Email = "george.clooney@example.com", Phone = "07733445566" },
                new Guest { GuestId = 34, Name = "Helen Mirren", Email = "helen.mirren@example.com", Phone = "07844556677" },
                new Guest { GuestId = 35, Name = "Ian McKellen", Email = "ian.mckellen@example.com", Phone = "07955667788" },
                new Guest { GuestId = 36, Name = "Jessica Alba", Email = "jessica.alba@example.com", Phone = "07466778899" },
                new Guest { GuestId = 37, Name = "Kevin Hart", Email = "kevin.hart@example.com", Phone = "07377889900" },
                new Guest { GuestId = 38, Name = "Lana Del Rey", Email = "lana.del.rey@example.com", Phone = "07788990011" },
                new Guest { GuestId = 39, Name = "Michael Jordan", Email = "michael.jordan@example.com", Phone = "07899001122" },
                new Guest { GuestId = 40, Name = "Nancy Drew", Email = "nancy.drew@example.com", Phone = "07900112233" },
                new Guest { GuestId = 41, Name = "Oscar Wilde", Email = "oscar.wilde@example.com", Phone = "07411223344" },
                new Guest { GuestId = 42, Name = "Penelope Cruz", Email = "penelope.cruz@example.com", Phone = "07322334455" },
                new Guest { GuestId = 43, Name = "Quentin Tarantino", Email = "quentin.tarantino@example.com", Phone = "07733445566" },
                new Guest { GuestId = 44, Name = "Ryan Gosling", Email = "ryan.gosling@example.com", Phone = "07844556677" },
                new Guest { GuestId = 45, Name = "Scarlett Johansson", Email = "scarlett.johansson@example.com", Phone = "07955667788" }
            );

            // Seed data for GuestBookings
            modelBuilder.Entity<GuestBooking>().HasData(
                new GuestBooking { GuestBookingId = 1, GuestId = 1, EventId = 1, HasAttended = false },
                new GuestBooking { GuestBookingId = 2, GuestId = 15, EventId = 1, HasAttended = true },
                new GuestBooking { GuestBookingId = 3, GuestId = 7, EventId = 1, HasAttended = true },
                new GuestBooking { GuestBookingId = 4, GuestId = 2, EventId = 2, HasAttended = true },
                new GuestBooking { GuestBookingId = 5, GuestId = 12, EventId = 2, HasAttended = false },
                new GuestBooking { GuestBookingId = 6, GuestId = 15, EventId = 2, HasAttended = true },
                new GuestBooking { GuestBookingId = 7, GuestId = 3, EventId = 3, HasAttended = false },
                new GuestBooking { GuestBookingId = 8, GuestId = 8, EventId = 3, HasAttended = true },
                new GuestBooking { GuestBookingId = 9, GuestId = 4, EventId = 4, HasAttended = true },
                new GuestBooking { GuestBookingId = 10, GuestId = 9, EventId = 4, HasAttended = false },
                new GuestBooking { GuestBookingId = 11, GuestId = 5, EventId = 5, HasAttended = false },
                new GuestBooking { GuestBookingId = 12, GuestId = 10, EventId = 5, HasAttended = true },
                new GuestBooking { GuestBookingId = 13, GuestId = 6, EventId = 5, HasAttended = true },
                new GuestBooking { GuestBookingId = 14, GuestId = 6, EventId = 6, HasAttended = true },
                new GuestBooking { GuestBookingId = 15, GuestId = 13, EventId = 6, HasAttended = false },
                new GuestBooking { GuestBookingId = 16, GuestId = 7, EventId = 7, HasAttended = false },
                new GuestBooking { GuestBookingId = 17, GuestId = 14, EventId = 7, HasAttended = true },
                new GuestBooking { GuestBookingId = 18, GuestId = 8, EventId = 8, HasAttended = true },
                new GuestBooking { GuestBookingId = 19, GuestId = 11, EventId = 8, HasAttended = false },
                new GuestBooking { GuestBookingId = 20, GuestId = 9, EventId = 9, HasAttended = false },
                new GuestBooking { GuestBookingId = 21, GuestId = 15, EventId = 9, HasAttended = true },
                new GuestBooking { GuestBookingId = 22, GuestId = 10, EventId = 10, HasAttended = true },
                new GuestBooking { GuestBookingId = 23, GuestId = 5, EventId = 10, HasAttended = false },
                new GuestBooking { GuestBookingId = 24, GuestId = 11, EventId = 11, HasAttended = false },
                new GuestBooking { GuestBookingId = 25, GuestId = 1, EventId = 11, HasAttended = true },
                new GuestBooking { GuestBookingId = 26, GuestId = 12, EventId = 12, HasAttended = true },
                new GuestBooking { GuestBookingId = 27, GuestId = 4, EventId = 12, HasAttended = false },
                new GuestBooking { GuestBookingId = 28, GuestId = 13, EventId = 13, HasAttended = false },
                new GuestBooking { GuestBookingId = 29, GuestId = 2, EventId = 13, HasAttended = true },
                new GuestBooking { GuestBookingId = 30, GuestId = 14, EventId = 14, HasAttended = true },
                new GuestBooking { GuestBookingId = 31, GuestId = 3, EventId = 14, HasAttended = false },
                new GuestBooking { GuestBookingId = 32, GuestId = 15, EventId = 15, HasAttended = true },
                new GuestBooking { GuestBookingId = 33, GuestId = 1, EventId = 15, HasAttended = true },
                new GuestBooking { GuestBookingId = 34, GuestId = 16, EventId = 1, HasAttended = false },
                new GuestBooking { GuestBookingId = 35, GuestId = 18, EventId = 2, HasAttended = true },
                new GuestBooking { GuestBookingId = 36, GuestId = 17, EventId = 3, HasAttended = false },
                new GuestBooking { GuestBookingId = 37, GuestId = 19, EventId = 4, HasAttended = true },
                new GuestBooking { GuestBookingId = 38, GuestId = 20, EventId = 5, HasAttended = true },
                new GuestBooking { GuestBookingId = 39, GuestId = 21, EventId = 6, HasAttended = false },
                new GuestBooking { GuestBookingId = 40, GuestId = 22, EventId = 7, HasAttended = true },
                new GuestBooking { GuestBookingId = 41, GuestId = 23, EventId = 8, HasAttended = false },
                new GuestBooking { GuestBookingId = 42, GuestId = 24, EventId = 9, HasAttended = true },
                new GuestBooking { GuestBookingId = 43, GuestId = 25, EventId = 10, HasAttended = true },
                new GuestBooking { GuestBookingId = 44, GuestId = 26, EventId = 11, HasAttended = false },
                new GuestBooking { GuestBookingId = 45, GuestId = 27, EventId = 12, HasAttended = true },
                new GuestBooking { GuestBookingId = 46, GuestId = 28, EventId = 13, HasAttended = false },
                new GuestBooking { GuestBookingId = 47, GuestId = 29, EventId = 14, HasAttended = true },
                new GuestBooking { GuestBookingId = 48, GuestId = 30, EventId = 15, HasAttended = true }
            );


            modelBuilder.Entity<Staff>().HasData(
                new Staff { StaffId = 1, Name = "Anna White", Role = "Manager" },
                new Staff { StaffId = 2, Name = "Ben Thomas", Role = "Manager" },
                new Staff { StaffId = 3, Name = "Cathy Holmes", Role = "Manager" },
                new Staff { StaffId = 4, Name = "David Chen", Role = "Manager" },
                new Staff { StaffId = 5, Name = "Emily Brown", Role = "Manager" },
                new Staff { StaffId = 6, Name = "Fred Johnson", Role = "Manager" },
                new Staff { StaffId = 7, Name = "George Lee", Role = "Manager" },
                new Staff { StaffId = 8, Name = "Helen Davis", Role = "Manager" },
                new Staff { StaffId = 9, Name = "Irene Scott", Role = "Manager" },
                new Staff { StaffId = 10, Name = "Jackie Ray", Role = "Manager" },
                new Staff { StaffId = 11, Name = "Kevin Moore", Role = "Manager" },
                new Staff { StaffId = 12, Name = "Lily Green", Role = "Manager" },
                new Staff { StaffId = 13, Name = "Mike Taylor", Role = "Manager" },
                new Staff { StaffId = 14, Name = "Nina Brooks", Role = "Manager" },
                new Staff { StaffId = 15, Name = "Oscar Peterson", Role = "Manager" },
                new Staff { StaffId = 16, Name = "Patricia Ward", Role = "Manager" },
                new Staff { StaffId = 17, Name = "Quincy Adams", Role = "Manager" },
                new Staff { StaffId = 18, Name = "Rachel King", Role = "Manager" },
                new Staff { StaffId = 19, Name = "Samuel Turner", Role = "Manager" },
                new Staff { StaffId = 20, Name = "Tina Evans", Role = "Manager" },
                new Staff { StaffId = 21, Name = "Uma Patel", Role = "Assistant" },
                new Staff { StaffId = 22, Name = "Victor Stone", Role = "Assistant" },
                new Staff { StaffId = 23, Name = "Wendy Clark", Role = "Assistant" },
                new Staff { StaffId = 24, Name = "Xavier Lewis", Role = "Assistant" },
                new Staff { StaffId = 25, Name = "Yvonne Carter", Role = "Assistant" },
                new Staff { StaffId = 26, Name = "Zachary Morgan", Role = "Assistant" },
                new Staff { StaffId = 27, Name = "Alan Fisher", Role = "Assistant" },
                new Staff { StaffId = 28, Name = "Betty Reid", Role = "Assistant" },
                new Staff { StaffId = 29, Name = "Carl Young", Role = "Assistant" },
                new Staff { StaffId = 30, Name = "Diana Holt", Role = "Assistant" },
                new Staff { StaffId = 31, Name = "Evan Lee", Role = "Assistant" },
                new Staff { StaffId = 32, Name = "Fiona Grant", Role = "Assistant" },
                new Staff { StaffId = 33, Name = "Gordon Blake", Role = "Assistant" },
                new Staff { StaffId = 34, Name = "Hannah Mills", Role = "Assistant" },
                new Staff { StaffId = 35, Name = "Ian Cooper", Role = "Assistant" },
                new Staff { StaffId = 36, Name = "Jenna Foster", Role = "Assistant" },
                new Staff { StaffId = 37, Name = "Kyle Brown", Role = "Assistant" },
                new Staff { StaffId = 38, Name = "Laura White", Role = "Assistant" },
                new Staff { StaffId = 39, Name = "Martin Smith", Role = "Assistant" },
                new Staff { StaffId = 40, Name = "Nancy Clark", Role = "Assistant" },
                new Staff { StaffId = 41, Name = "Oliver Harris", Role = "Assistant" },
                new Staff { StaffId = 42, Name = "Paula Cook", Role = "Assistant" },
                new Staff { StaffId = 43, Name = "Quentin Brooks", Role = "Assistant" },
                new Staff { StaffId = 44, Name = "Rachel Adams", Role = "Assistant" },
                new Staff { StaffId = 45, Name = "Simon Lewis", Role = "Assistant" },
                new Staff { StaffId = 46, Name = "Tina Ford", Role = "Assistant" },
                new Staff { StaffId = 47, Name = "Uma West", Role = "Assistant" },
                new Staff { StaffId = 48, Name = "Victor Hall", Role = "Assistant" },
                new Staff { StaffId = 49, Name = "Wendy Morris", Role = "First Aider" },
                new Staff { StaffId = 50, Name = "Xander Price", Role = "First Aider" },
                new Staff { StaffId = 51, Name = "Yasmine Stone", Role = "First Aider" },
                new Staff { StaffId = 52, Name = "Zara Lloyd", Role = "First Aider" },
                new Staff { StaffId = 53, Name = "Aaron Jenkins", Role = "First Aider" },
                new Staff { StaffId = 54, Name = "Bethany Hill", Role = "First Aider" },
                new Staff { StaffId = 55, Name = "Chris Parker", Role = "First Aider" },
                new Staff { StaffId = 56, Name = "Donna Evans", Role = "First Aider" },
                new Staff { StaffId = 57, Name = "Elliot Hayes", Role = "First Aider" },
                new Staff { StaffId = 58, Name = "Felicity Ross", Role = "First Aider" },
                new Staff { StaffId = 59, Name = "George Carter", Role = "First Aider" },
                new Staff { StaffId = 60, Name = "Heather Turner", Role = "First Aider" }
            );

            // Seed data for Staffing
            modelBuilder.Entity<Staffing>().HasData(
                new Staffing { StaffingId = 1, EventId = 1, StaffId = 1 },
                new Staffing { StaffingId = 2, EventId = 1, StaffId = 21 },
                new Staffing { StaffingId = 3, EventId = 1, StaffId = 22 },
                new Staffing { StaffingId = 4, EventId = 2, StaffId = 2 },
                new Staffing { StaffingId = 5, EventId = 2, StaffId = 23 },
                new Staffing { StaffingId = 6, EventId = 3, StaffId = 3 },
                new Staffing { StaffingId = 7, EventId = 3, StaffId = 24 },
                new Staffing { StaffingId = 8, EventId = 3, StaffId = 25 },
                new Staffing { StaffingId = 9, EventId = 4, StaffId = 4 },
                new Staffing { StaffingId = 10, EventId = 4, StaffId = 26 },
                new Staffing { StaffingId = 11, EventId = 5, StaffId = 5 },
                new Staffing { StaffingId = 12, EventId = 6, StaffId = 6 },
                new Staffing { StaffingId = 13, EventId = 6, StaffId = 27 },
                new Staffing { StaffingId = 14, EventId = 7, StaffId = 7 },
                new Staffing { StaffingId = 15, EventId = 7, StaffId = 28 },
                new Staffing { StaffingId = 16, EventId = 7, StaffId = 29 },
                new Staffing { StaffingId = 17, EventId = 8, StaffId = 8 },
                new Staffing { StaffingId = 18, EventId = 9, StaffId = 9 },
                new Staffing { StaffingId = 19, EventId = 9, StaffId = 30 },
                new Staffing { StaffingId = 20, EventId = 10, StaffId = 10 },
                new Staffing { StaffingId = 21, EventId = 11, StaffId = 11 },
                new Staffing { StaffingId = 22, EventId = 11, StaffId = 31 },
                new Staffing { StaffingId = 23, EventId = 12, StaffId = 12 },
                new Staffing { StaffingId = 24, EventId = 13, StaffId = 13 },
                new Staffing { StaffingId = 25, EventId = 13, StaffId = 32 },
                new Staffing { StaffingId = 26, EventId = 14, StaffId = 14 },
                new Staffing { StaffingId = 27, EventId = 14, StaffId = 33 },
                new Staffing { StaffingId = 28, EventId = 15, StaffId = 15 },
                new Staffing { StaffingId = 29, EventId = 15, StaffId = 34 }
            );
        }
    }
}
