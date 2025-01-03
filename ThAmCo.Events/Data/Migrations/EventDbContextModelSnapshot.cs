﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Events.Data;

#nullable disable

namespace ThAmCo.Events.Data.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("ThAmCo.Events.Data.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueReference")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            Date = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "17:00:00",
                            EventType = "EXH",
                            StartTime = "09:00:00",
                            Title = "Tech Expo",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 2,
                            Date = new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "15:00:00",
                            EventType = "WKS",
                            StartTime = "10:00:00",
                            Title = "AI Workshop",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 3,
                            Date = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "23:00:00",
                            EventType = "GAL",
                            StartTime = "19:00:00",
                            Title = "Annual Gala Dinner",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 4,
                            Date = new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "18:00:00",
                            EventType = "CMP",
                            StartTime = "09:00:00",
                            Title = "Coding Hackathon",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 5,
                            Date = new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "16:30:00",
                            EventType = "OTR",
                            StartTime = "08:30:00",
                            Title = "Marketing Summit",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 6,
                            Date = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "20:00:00",
                            EventType = "CMP",
                            StartTime = "14:00:00",
                            Title = "Startup Pitch Fest",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 7,
                            Date = new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "16:00:00",
                            EventType = "EXH",
                            StartTime = "10:00:00",
                            Title = "Science Fair",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 8,
                            Date = new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "22:00:00",
                            EventType = "FND",
                            StartTime = "18:00:00",
                            Title = "Charity Auction",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 9,
                            Date = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "17:00:00",
                            EventType = "WKS",
                            StartTime = "13:00:00",
                            Title = "Photography Workshop",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 10,
                            Date = new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "18:00:00",
                            EventType = "EXH",
                            StartTime = "10:00:00",
                            Title = "Art & Design Expo",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 11,
                            Date = new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "21:30:00",
                            EventType = "NET",
                            StartTime = "19:00:00",
                            Title = "Developer Meetup",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 12,
                            Date = new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "15:00:00",
                            EventType = "OTR",
                            StartTime = "09:00:00",
                            Title = "Community Volunteering",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 13,
                            Date = new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "22:00:00",
                            EventType = "FES",
                            StartTime = "14:00:00",
                            Title = "Holiday Festival",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 14,
                            Date = new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "16:30:00",
                            EventType = "WKS",
                            StartTime = "09:30:00",
                            Title = "Leadership Seminar",
                            isCancelled = false
                        },
                        new
                        {
                            EventId = 15,
                            Date = new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = "23:59:00",
                            EventType = "FES",
                            StartTime = "20:00:00",
                            Title = "End-of-Year Party",
                            isCancelled = false
                        });
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            GuestId = 1,
                            Email = "alice.johnson@example.com",
                            Name = "Alice Johnson",
                            Phone = "1234567890"
                        },
                        new
                        {
                            GuestId = 2,
                            Email = "bob.smith@example.com",
                            Name = "Bob Smith",
                            Phone = "2345678901"
                        },
                        new
                        {
                            GuestId = 3,
                            Email = "charlie.brown@example.com",
                            Name = "Charlie Brown",
                            Phone = "3456789012"
                        },
                        new
                        {
                            GuestId = 4,
                            Email = "diana.prince@example.com",
                            Name = "Diana Prince",
                            Phone = "4567890123"
                        },
                        new
                        {
                            GuestId = 5,
                            Email = "eve.adams@example.com",
                            Name = "Eve Adams",
                            Phone = "5678901234"
                        },
                        new
                        {
                            GuestId = 6,
                            Email = "frank.harris@example.com",
                            Name = "Frank Harris",
                            Phone = "6789012345"
                        },
                        new
                        {
                            GuestId = 7,
                            Email = "grace.lee@example.com",
                            Name = "Grace Lee",
                            Phone = "7890123456"
                        },
                        new
                        {
                            GuestId = 8,
                            Email = "hank.hill@example.com",
                            Name = "Hank Hill",
                            Phone = "8901234567"
                        },
                        new
                        {
                            GuestId = 9,
                            Email = "ivy.nguyen@example.com",
                            Name = "Ivy Nguyen",
                            Phone = "9012345678"
                        },
                        new
                        {
                            GuestId = 10,
                            Email = "jack.miller@example.com",
                            Name = "Jack Miller",
                            Phone = "0123456789"
                        },
                        new
                        {
                            GuestId = 11,
                            Email = "kelly.green@example.com",
                            Name = "Kelly Green",
                            Phone = "1122334455"
                        },
                        new
                        {
                            GuestId = 12,
                            Email = "luke.skywalker@example.com",
                            Name = "Luke Skywalker",
                            Phone = "2233445566"
                        },
                        new
                        {
                            GuestId = 13,
                            Email = "maria.garcia@example.com",
                            Name = "Maria Garcia",
                            Phone = "3344556677"
                        },
                        new
                        {
                            GuestId = 14,
                            Email = "nathan.drake@example.com",
                            Name = "Nathan Drake",
                            Phone = "4455667788"
                        },
                        new
                        {
                            GuestId = 15,
                            Email = "olivia.king@example.com",
                            Name = "Olivia King",
                            Phone = "5566778899"
                        });
                });

            modelBuilder.Entity("ThAmCo.Events.Data.GuestBooking", b =>
                {
                    b.Property<int>("GuestBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuestId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasAttended")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("INTEGER");

                    b.HasKey("GuestBookingId");

                    b.HasIndex("EventId");

                    b.HasIndex("GuestId");

                    b.ToTable("GuestBookings");

                    b.HasData(
                        new
                        {
                            GuestBookingId = 1,
                            EventId = 1,
                            GuestId = 1,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 2,
                            EventId = 2,
                            GuestId = 2,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 3,
                            EventId = 3,
                            GuestId = 3,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 4,
                            EventId = 4,
                            GuestId = 4,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 5,
                            EventId = 5,
                            GuestId = 5,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 6,
                            EventId = 6,
                            GuestId = 6,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 7,
                            EventId = 7,
                            GuestId = 7,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 8,
                            EventId = 8,
                            GuestId = 8,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 9,
                            EventId = 9,
                            GuestId = 9,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 10,
                            EventId = 10,
                            GuestId = 10,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 11,
                            EventId = 11,
                            GuestId = 11,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 12,
                            EventId = 12,
                            GuestId = 12,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 13,
                            EventId = 13,
                            GuestId = 13,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 14,
                            EventId = 14,
                            GuestId = 14,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 15,
                            EventId = 15,
                            GuestId = 15,
                            HasAttended = false,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 16,
                            EventId = 1,
                            GuestId = 15,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 17,
                            EventId = 2,
                            GuestId = 15,
                            HasAttended = true,
                            IsCancelled = false
                        },
                        new
                        {
                            GuestBookingId = 18,
                            EventId = 15,
                            GuestId = 1,
                            HasAttended = true,
                            IsCancelled = false
                        });
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StaffId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            Name = "Anna White",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 2,
                            Name = "Ben Thomas",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 3,
                            Name = "Cathy Holmes",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 4,
                            Name = "David Chen",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 5,
                            Name = "Emily Brown",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 6,
                            Name = "Fred Johnson",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 7,
                            Name = "George Lee",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 8,
                            Name = "Helen Davis",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 9,
                            Name = "Irene Scott",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 10,
                            Name = "Jackie Ray",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 11,
                            Name = "Kevin Moore",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 12,
                            Name = "Lily Green",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 13,
                            Name = "Mike Taylor",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 14,
                            Name = "Nina Brooks",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 15,
                            Name = "Oscar Peterson",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 16,
                            Name = "Patricia Ward",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 17,
                            Name = "Quincy Adams",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 18,
                            Name = "Rachel King",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 19,
                            Name = "Samuel Turner",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 20,
                            Name = "Tina Evans",
                            Role = "Manager"
                        },
                        new
                        {
                            StaffId = 21,
                            Name = "Uma Patel",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 22,
                            Name = "Victor Stone",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 23,
                            Name = "Wendy Clark",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 24,
                            Name = "Xavier Lewis",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 25,
                            Name = "Yvonne Carter",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 26,
                            Name = "Zachary Morgan",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 27,
                            Name = "Alan Fisher",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 28,
                            Name = "Betty Reid",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 29,
                            Name = "Carl Young",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 30,
                            Name = "Diana Holt",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 31,
                            Name = "Evan Lee",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 32,
                            Name = "Fiona Grant",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 33,
                            Name = "Gordon Blake",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 34,
                            Name = "Hannah Mills",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 35,
                            Name = "Ian Cooper",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 36,
                            Name = "Jenna Foster",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 37,
                            Name = "Kyle Brown",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 38,
                            Name = "Laura White",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 39,
                            Name = "Martin Smith",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 40,
                            Name = "Nancy Clark",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 41,
                            Name = "Oliver Harris",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 42,
                            Name = "Paula Cook",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 43,
                            Name = "Quentin Brooks",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 44,
                            Name = "Rachel Adams",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 45,
                            Name = "Simon Lewis",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 46,
                            Name = "Tina Ford",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 47,
                            Name = "Uma West",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 48,
                            Name = "Victor Hall",
                            Role = "Assistant"
                        },
                        new
                        {
                            StaffId = 49,
                            Name = "Wendy Morris",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 50,
                            Name = "Xander Price",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 51,
                            Name = "Yasmine Stone",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 52,
                            Name = "Zara Lloyd",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 53,
                            Name = "Aaron Jenkins",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 54,
                            Name = "Bethany Hill",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 55,
                            Name = "Chris Parker",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 56,
                            Name = "Donna Evans",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 57,
                            Name = "Elliot Hayes",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 58,
                            Name = "Felicity Ross",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 59,
                            Name = "George Carter",
                            Role = "First Aider"
                        },
                        new
                        {
                            StaffId = 60,
                            Name = "Heather Turner",
                            Role = "First Aider"
                        });
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staffing", b =>
                {
                    b.Property<int>("StaffingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StaffingId");

                    b.HasIndex("EventId");

                    b.HasIndex("StaffId");

                    b.ToTable("Staffing");
                });

            modelBuilder.Entity("ThAmCo.Events.Data.GuestBooking", b =>
                {
                    b.HasOne("ThAmCo.Events.Data.Event", "Event")
                        .WithMany("GuestBookings")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThAmCo.Events.Data.Guest", "Guest")
                        .WithMany("GuestBookings")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staffing", b =>
                {
                    b.HasOne("ThAmCo.Events.Data.Event", "Event")
                        .WithMany("Staffings")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThAmCo.Events.Data.Staff", "Staff")
                        .WithMany("Staffings")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Event", b =>
                {
                    b.Navigation("GuestBookings");

                    b.Navigation("Staffings");
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Guest", b =>
                {
                    b.Navigation("GuestBookings");
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staff", b =>
                {
                    b.Navigation("Staffings");
                });
#pragma warning restore 612, 618
        }
    }
}
