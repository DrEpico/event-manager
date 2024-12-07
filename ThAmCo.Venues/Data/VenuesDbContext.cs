using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Venues.Data
{
    public class VenuesDbContext : DbContext
    {
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Suitability> Suitabilities { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        private readonly IHostEnvironment _hostEnv;
        private readonly string DbPath;

        public VenuesDbContext(DbContextOptions<VenuesDbContext> options, IHostEnvironment env) : base(options)
        {
            _hostEnv = env;

            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ThAmCo.Venues.db");
            Console.WriteLine($"Database Path: {DbPath}");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Suitability>()
                   .HasKey(s => new { s.EventTypeId, s.VenueCode });

            builder.Entity<EventType>()
                   .Property(e => e.Id)
                   .IsFixedLength();

            builder.Entity<Suitability>()
                   .Property(e => e.EventTypeId)
                   .IsFixedLength();

            builder.Entity<Suitability>()
                   .Property(e => e.VenueCode)
                   .IsFixedLength();

            builder.Entity<EventType>()
                   .HasMany(e => e.SuitableVenues)
                   .WithOne(s => s.EventType)
                   .HasForeignKey(s => s.EventTypeId);

            builder.Entity<Venue>()
                   .Property(v => v.Code)
                   .IsFixedLength();

            builder.Entity<Venue>()
                   .HasMany(v => v.SuitableEventTypes)
                   .WithOne(s => s.Venue)
                   .HasForeignKey(s => s.VenueCode);

            builder.Entity<Venue>()
                   .HasMany(v => v.AvailableDates)
                   .WithOne(a => a.Venue)
                   .HasForeignKey(a => a.VenueCode);

            builder.Entity<Availability>()
                   .Property(v => v.VenueCode)
                   .IsFixedLength();

            builder.Entity<Availability>()
                   .HasKey(a => new { a.Date, a.VenueCode });


            builder.Entity<Reservation>()
                   .Property(r => r.Reference)
                   .IsFixedLength();

            builder.Entity<Reservation>()
                   .Property(v => v.VenueCode)
                   .IsFixedLength();

            builder.Entity<Reservation>()
                   .HasOne(r => r.Availability)
                   .WithOne(a => a.Reservation)
                   .IsRequired()
                   // prevent an Availability being deleted if there's a Reservation
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<EventType>()
                   .HasData(
                        new EventType { Id = "EXH", Title = "Exhibition" },
                        new EventType { Id = "WKS", Title = "Workshop" },
                        new EventType { Id = "GAL", Title = "Gala" },
                        new EventType { Id = "CMP", Title = "Competition" },
                        new EventType { Id = "FND", Title = "Fundraiser"},
                        new EventType { Id = "NET", Title = "Networking" },
                        new EventType { Id = "OTR", Title = "Outreach" },
                        new EventType { Id = "FES", Title = "Festival"}
                    );

            if (_hostEnv != null && _hostEnv.IsDevelopment())
            {
                builder.Entity<Venue>()
                   .HasData(
                        new Venue { Code = "CRKHL", Name = "Crackling Hall", Description = "Once the residence of Lord and Lady Crackling.", Capacity = 150 },
                        new Venue { Code = "TNDMR", Name = "Tinder Manor", Description = "Refurbished manor house with equipped facilities.", Capacity = 450 },
                        new Venue { Code = "FDLCK", Name = "The Fiddler's Cockatoo", Description = "Rustic pub in idyllic countryside.", Capacity = 85 },
                        new Venue { Code = "SUNPL", Name = "Sunset Pavilion", Description = "Spacious waterfront venue.", Capacity = 1200 },
                        new Venue { Code = "SLTCR", Name = "Saltmarsh Retreat", Description = "Quiet and serene location ideal for outreach.", Capacity = 200 },
                        new Venue { Code = "BLKTW", Name = "Blackthorn Workshop", Description = "Facility for workshops and exhibitions.", Capacity = 100 },
                        new Venue { Code = "LNKRY", Name = "The Linkery", Description = "Modern networking venue with high-speed internet.", Capacity = 300 },
                        new Venue { Code = "STGHM", Name = "Stargaze Hall", Description = "Historical gala venue with starry ceilings.", Capacity = 500 },
                        new Venue { Code = "CMPGR", Name = "Competition Grounds", Description = "Purpose-built grounds for hosting competitions.", Capacity = 800 },
                        new Venue { Code = "HMSCR", Name = "HomeScape Cradle", Description = "Exhibition space for home innovations.", Capacity = 250 },
                        new Venue { Code = "GLTNK", Name = "Glisten Tank", Description = "Fundraiser venue with underwater gallery.", Capacity = 400 },
                        new Venue { Code = "WTHTR", Name = "Willow Theatre", Description = "Theatre for festivals and cultural events.", Capacity = 220 },
                        new Venue { Code = "BRCHH", Name = "Birch Hall", Description = "Charming venue surrounded by birch woods.", Capacity = 350 },
                        new Venue { Code = "RIVPT", Name = "Riverpoint Terrace", Description = "Perfect for outdoor gatherings by the river.", Capacity = 600 },
                        new Venue { Code = "HNTWM", Name = "Huntwick Manor", Description = "Countryside estate for high-profile galas.", Capacity = 450 },
                        new Venue { Code = "MNSYN", Name = "Moonshine Inn", Description = "Rustic tavern known for its festive atmosphere.", Capacity = 100 },
                        new Venue { Code = "WDRSC", Name = "Woodrose Castle", Description = "Castle with a history of hosting royal galas.", Capacity = 700 },
                        new Venue { Code = "SPHRD", Name = "Sapphire Docks", Description = "Waterside venue great for festivals and exhibitions.", Capacity = 500 },
                        new Venue { Code = "ELMRG", Name = "Elm Ridge Gardens", Description = "Picturesque gardens ideal for fundraisers.", Capacity = 150 },
                        new Venue { Code = "STPFL", Name = "Stepfield Hall", Description = "Multipurpose space for conferences and exhibitions.", Capacity = 400 }
                   );

                builder.Entity<Suitability>()
                   .HasData(
                        new Suitability { VenueCode = "CRKHL", EventTypeId = "GAL" },
                        new Suitability { VenueCode = "CRKHL", EventTypeId = "EXH" },
                        new Suitability { VenueCode = "TNDMR", EventTypeId = "WKS" },
                        new Suitability { VenueCode = "TNDMR", EventTypeId = "NET" },
                        new Suitability { VenueCode = "FDLCK", EventTypeId = "FND" },
                        new Suitability { VenueCode = "SUNPL", EventTypeId = "FES" },
                        new Suitability { VenueCode = "SUNPL", EventTypeId = "EXH" },
                        new Suitability { VenueCode = "SLTCR", EventTypeId = "OTR" },
                        new Suitability { VenueCode = "BLKTW", EventTypeId = "WKS" },
                        new Suitability { VenueCode = "LNKRY", EventTypeId = "NET" },
                        new Suitability { VenueCode = "STGHM", EventTypeId = "GAL" },
                        new Suitability { VenueCode = "CMPGR", EventTypeId = "CMP" },
                        new Suitability { VenueCode = "HMSCR", EventTypeId = "EXH" },
                        new Suitability { VenueCode = "GLTNK", EventTypeId = "FND" },
                        new Suitability { VenueCode = "WTHTR", EventTypeId = "FES" },
                        new Suitability { VenueCode = "BRCHH", EventTypeId = "WKS" },
                        new Suitability { VenueCode = "RIVPT", EventTypeId = "FES" },
                        new Suitability { VenueCode = "HNTWM", EventTypeId = "GAL" },
                        new Suitability { VenueCode = "MNSYN", EventTypeId = "FND" },
                        new Suitability { VenueCode = "WDRSC", EventTypeId = "GAL" },
                        new Suitability { VenueCode = "SPHRD", EventTypeId = "FES" },
                        new Suitability { VenueCode = "ELMRG", EventTypeId = "FND" },
                        new Suitability { VenueCode = "STPFL", EventTypeId = "EXH" }
                   );


                var rand = new Random(0);
                var startDate = new DateTime(2024, 12, 01);
                var endDate = startDate.AddDays(14); // 2 weeks of availability
                var dates = new List<Availability>();
                var venues = new[]
                {
                    new { Venue = "CRKHL", Cost = 50.0 },
                    new { Venue = "TNDMR", Cost = 70.0 },
                    new { Venue = "FDLCK", Cost = 30.0 },
                    new { Venue = "SUNPL", Cost = 120.0 },
                    new { Venue = "SLTCR", Cost = 40.0 },
                    new { Venue = "BLKTW", Cost = 35.0 },
                    new { Venue = "LNKRY", Cost = 60.0 },
                    new { Venue = "STGHM", Cost = 80.0 },
                    new { Venue = "CMPGR", Cost = 100.0 },
                    new { Venue = "HMSCR", Cost = 55.0 },
                    new { Venue = "GLTNK", Cost = 90.0 },
                    new { Venue = "WTHTR", Cost = 65.0 },
                    new { Venue = "BRCHH", Cost = 45.0 },
                    new { Venue = "RIVPT", Cost = 85.0 },
                    new { Venue = "HNTWM", Cost = 75.0 },
                    new { Venue = "MNSYN", Cost = 40.0 },
                    new { Venue = "WDRSC", Cost = 110.0 },
                    new { Venue = "SPHRD", Cost = 100.0 },
                    new { Venue = "ELMRG", Cost = 50.0 },
                    new { Venue = "STPFL", Cost = 70.0 }
                }.ToList();
                //JUSTIFICATION: I would've had it generate availability for the next 3 months from 1st Dec for 20 venues but that would take
                //  20 minutes so since this is for demonstration purposes anyway ill keep it down to 2 weeks worth of availability.
                //  After the changes it now takes 2,3 minutes to generate the availabilities so go grab water and hydrate while you wait lol
                venues.ForEach(v =>
                {
                    // Generate dates for the 2-week period
                    var days = Enumerable.Range(0, (endDate - startDate).Days + 1);

                    // Confirm the range
                    Console.WriteLine($"Generating data from {startDate} to {endDate}");

                    foreach (var dayOffset in days)
                    {
                        var dayDate = startDate.AddDays(dayOffset);

                        // Create a single 24-hour availability slot for the venue
                        dates.Add(new Availability
                        {
                            VenueCode = v.Venue,
                            Date = new DateTime(dayDate.Year, dayDate.Month, dayDate.Day, 0, 0, 0), // Start of the day
                            CostPerHour = Math.Round(v.Cost * (1.0 + rand.NextDouble()), 2)
                        });
                    }
                });

                // Seed all generated data into the database
                var availabilities = dates
                    .OrderBy(d => d.Date) // Order by date and time
                    .ToArray();

                builder.Entity<Availability>()
                       .HasData(availabilities);
            }
        }


    }
}
