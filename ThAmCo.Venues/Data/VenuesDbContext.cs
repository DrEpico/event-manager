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
                        new Venue { Code = "CRKHL", Name = "Crackling Hall", Description = "Once the residence of Lord and Lady Crackling, this lavish dwelling remains a prime example of 18th century fine living.", Capacity = 150 },
                        new Venue { Code = "TNDMR", Name = "Tinder Manor", Description = "Refurbished manor house with fully equipped facilities ready to help you have a good time in business or pleasure.", Capacity = 450 },
                        new Venue { Code = "FDLCK", Name = "The Fiddler's Cockatoo", Description = "Rustic pub set in idyllic countryside, the original venue of a notorious local musician and his parrot.", Capacity = 85 },
                        new Venue { Code = "SUNPL", Name = "Sunset Pavilion", Description = "A spacious venue by the waterfront, perfect for festivals and large gatherings.", Capacity = 1200 },
                        new Venue { Code = "SLTCR", Name = "Saltmarsh Retreat", Description = "A quiet and serene location ideal for outreach and nature-focused events.", Capacity = 200 },
                        new Venue { Code = "BLKTW", Name = "Blackthorn Workshop", Description = "An innovative facility equipped for hands-on workshops and small exhibitions.", Capacity = 100 },
                        new Venue { Code = "LNKRY", Name = "The Linkery", Description = "A modern networking venue with high-speed internet and breakout rooms.", Capacity = 300 },
                        new Venue { Code = "STGHM", Name = "Stargaze Hall", Description = "A historical gala venue known for its starry ceilings and lavish interiors.", Capacity = 500 },
                        new Venue { Code = "CMPGR", Name = "Competition Grounds", Description = "Purpose-built grounds for hosting local and national competitions.", Capacity = 800 },
                        new Venue { Code = "HMSCR", Name = "HomeScape Cradle", Description = "A unique exhibition space for showcasing home and garden innovations.", Capacity = 250 },
                        new Venue { Code = "GLTNK", Name = "Glisten Tank", Description = "A fundraiser venue featuring an underwater observation gallery.", Capacity = 400 },
                        new Venue { Code = "WTHTR", Name = "Willow Theatre", Description = "A charming theatre perfect for cultural festivals and performances.", Capacity = 220 }
                   );


                builder.Entity<Suitability>()
                   .HasData(
                        new Suitability { VenueCode = "CRKHL", EventTypeId = "GAL" },  // Gala
                        new Suitability { VenueCode = "CRKHL", EventTypeId = "EXH" },  // Exhibition
                        new Suitability { VenueCode = "CRKHL", EventTypeId = "FND" },  // Fundraiser
                        new Suitability { VenueCode = "TNDMR", EventTypeId = "WKS" },  // Workshop
                        new Suitability { VenueCode = "TNDMR", EventTypeId = "NET" },  // Networking
                        new Suitability { VenueCode = "TNDMR", EventTypeId = "CMP" }, // Competition
                        new Suitability { VenueCode = "FDLCK", EventTypeId = "FND" },  // Fundraiser
                        new Suitability { VenueCode = "FDLCK", EventTypeId = "OTR" },  // Outreach
                        new Suitability { VenueCode = "SUNPL", EventTypeId = "FES" },  // Festival
                        new Suitability { VenueCode = "SUNPL", EventTypeId = "EXH" },  // Exhibition
                        new Suitability { VenueCode = "SLTCR", EventTypeId = "OTR" },  // Outreach
                        new Suitability { VenueCode = "SLTCR", EventTypeId = "WKS" },  // Workshop
                        new Suitability { VenueCode = "BLKTW", EventTypeId = "WKS" },  // Workshop
                        new Suitability { VenueCode = "BLKTW", EventTypeId = "EXH" },  // Exhibition
                        new Suitability { VenueCode = "LNKRY", EventTypeId = "NET" },  // Networking
                        new Suitability { VenueCode = "LNKRY", EventTypeId = "MET" },  // Meeting
                        new Suitability { VenueCode = "STGHM", EventTypeId = "GAL" },  // Gala
                        new Suitability { VenueCode = "CMPGR", EventTypeId = "CMP" }, // Competition
                        new Suitability { VenueCode = "CMPGR", EventTypeId = "EXH" },  // Exhibition
                        new Suitability { VenueCode = "HMSCR", EventTypeId = "EXH" },  // Exhibition
                        new Suitability { VenueCode = "HMSCR", EventTypeId = "FND" },  // Fundraiser
                        new Suitability { VenueCode = "GLTNK", EventTypeId = "FND" },  // Fundraiser
                        new Suitability { VenueCode = "WTHTR", EventTypeId = "FES" },  // Festival
                        new Suitability { VenueCode = "WTHTR", EventTypeId = "EXH" }   // Exhibition
                   );


                var rand = new Random(0);
                var startDate = new DateTime(2022, 11, 01);
                var dates = new List<Availability>();
                var venues = new[] {
                    new { Venue = "FDLCK", Cost = 30.0 },
                    new { Venue = "CRKHL", Cost = 50.0 },
                    new { Venue = "TNDMR", Cost = 70.0 }
                }.ToList();
                venues.ForEach(v =>
                {
                    var more = Enumerable.Range(0, 90)
                        .Select(i => new Availability
                        {
                            VenueCode = v.Venue,
                            Date = startDate.AddDays(i),
                            CostPerHour = Math.Round(v.Cost * (1.0 + rand.NextDouble()), 2)
                        });
                    dates.AddRange(more);
                });
                var availabilities = dates.Where(d => rand.NextDouble() < 0.3)
                                          .OrderBy(d => d.Date)
                                          .ToArray();
                builder.Entity<Availability>()
                       .HasData(availabilities);
            }
        }


    }
}
