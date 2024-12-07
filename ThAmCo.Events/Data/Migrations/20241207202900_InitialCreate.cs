using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartTime = table.Column<string>(type: "TEXT", nullable: false),
                    EndTime = table.Column<string>(type: "TEXT", nullable: false),
                    EventType = table.Column<string>(type: "TEXT", nullable: false),
                    VenueCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "GuestBookings",
                columns: table => new
                {
                    GuestBookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuestId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    HasAttended = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestBookings", x => x.GuestBookingId);
                    table.ForeignKey(
                        name: "FK_GuestBookings_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestBookings_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffing",
                columns: table => new
                {
                    StaffingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StaffId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffing", x => x.StaffingId);
                    table.ForeignKey(
                        name: "FK_Staffing_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffing_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Date", "EndTime", "EventType", "StartTime", "Title", "VenueCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:00:00", "Exhibition", "09:00:00", "Tech Expo", null },
                    { 2, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "15:00:00", "Workshop", "10:00:00", "AI Workshop", null },
                    { 3, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "23:00:00", "Gala", "19:00:00", "Annual Gala Dinner", null },
                    { 4, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "18:00:00", "Competition", "09:00:00", "Coding Hackathon", null },
                    { 5, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:30:00", "Conference", "08:30:00", "Marketing Summit", null },
                    { 6, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "20:00:00", "Competition", "14:00:00", "Startup Pitch Fest", null },
                    { 7, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:00:00", "Exhibition", "10:00:00", "Science Fair", null },
                    { 8, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "22:00:00", "Fundraiser", "18:00:00", "Charity Auction", null },
                    { 9, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:00:00", "Workshop", "13:00:00", "Photography Workshop", null },
                    { 10, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "18:00:00", "Exhibition", "10:00:00", "Art & Design Expo", null },
                    { 11, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "21:30:00", "Networking", "19:00:00", "Developer Meetup", null },
                    { 12, new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "15:00:00", "Outreach", "09:00:00", "Community Volunteering", null },
                    { 13, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "22:00:00", "Festival", "14:00:00", "Holiday Festival", null },
                    { 14, new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:30:00", "Workshop", "09:30:00", "Leadership Seminar", null },
                    { 15, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "23:59:00", "Festival", "20:00:00", "End-of-Year Party", null }
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "GuestId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "alice.johnson@example.com", "Alice Johnson", "1234567890" },
                    { 2, "bob.smith@example.com", "Bob Smith", "2345678901" },
                    { 3, "charlie.brown@example.com", "Charlie Brown", "3456789012" },
                    { 4, "diana.prince@example.com", "Diana Prince", "4567890123" },
                    { 5, "eve.adams@example.com", "Eve Adams", "5678901234" },
                    { 6, "frank.harris@example.com", "Frank Harris", "6789012345" },
                    { 7, "grace.lee@example.com", "Grace Lee", "7890123456" },
                    { 8, "hank.hill@example.com", "Hank Hill", "8901234567" },
                    { 9, "ivy.nguyen@example.com", "Ivy Nguyen", "9012345678" },
                    { 10, "jack.miller@example.com", "Jack Miller", "0123456789" },
                    { 11, "kelly.green@example.com", "Kelly Green", "1122334455" },
                    { 12, "luke.skywalker@example.com", "Luke Skywalker", "2233445566" },
                    { 13, "maria.garcia@example.com", "Maria Garcia", "3344556677" },
                    { 14, "nathan.drake@example.com", "Nathan Drake", "4455667788" },
                    { 15, "olivia.king@example.com", "Olivia King", "5566778899" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "Anna White", "Coordinator" },
                    { 2, "Ben Thomas", "Manager" },
                    { 3, "Cathy Holmes", "Assistant" },
                    { 4, "David Chen", "Coordinator" },
                    { 5, "Emily Brown", "Manager" },
                    { 6, "Fred Johnson", "Assistant" },
                    { 7, "George Lee", "Coordinator" },
                    { 8, "Helen Davis", "Manager" },
                    { 9, "Irene Scott", "Assistant" },
                    { 10, "Jackie Ray", "Coordinator" },
                    { 11, "Kevin Moore", "Manager" },
                    { 12, "Lily Green", "Assistant" },
                    { 13, "Mike Taylor", "Coordinator" },
                    { 14, "Nina Brooks", "Manager" },
                    { 15, "Oscar Peterson", "Assistant" },
                    { 16, "Patricia Ward", "Coordinator" },
                    { 17, "Quincy Adams", "Manager" },
                    { 18, "Rachel King", "Assistant" },
                    { 19, "Samuel Turner", "Coordinator" },
                    { 20, "Tina Evans", "Manager" },
                    { 21, "Uma Patel", "Assistant" },
                    { 22, "Victor Stone", "Coordinator" },
                    { 23, "Wendy Clark", "Manager" },
                    { 24, "Xavier Lewis", "Assistant" },
                    { 25, "Yvonne Carter", "Coordinator" }
                });

            migrationBuilder.InsertData(
                table: "GuestBookings",
                columns: new[] { "GuestBookingId", "EventId", "GuestId", "HasAttended" },
                values: new object[,]
                {
                    { 1, 1, 1, false },
                    { 2, 2, 2, true },
                    { 3, 3, 3, false },
                    { 4, 4, 4, true },
                    { 5, 5, 5, false },
                    { 6, 6, 6, true },
                    { 7, 7, 7, false },
                    { 8, 8, 8, true },
                    { 9, 9, 9, false },
                    { 10, 10, 10, true },
                    { 11, 11, 11, false },
                    { 12, 12, 12, true },
                    { 13, 13, 13, false },
                    { 14, 14, 14, true },
                    { 15, 15, 15, false },
                    { 16, 1, 15, true },
                    { 17, 2, 15, true },
                    { 18, 15, 1, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuestBookings_EventId",
                table: "GuestBookings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestBookings_GuestId",
                table: "GuestBookings",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffing_EventId",
                table: "Staffing",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffing_StaffId",
                table: "Staffing",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestBookings");

            migrationBuilder.DropTable(
                name: "Staffing");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
