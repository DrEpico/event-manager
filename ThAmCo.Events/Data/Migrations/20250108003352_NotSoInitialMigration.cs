using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class NotSoInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    VenueReference = table.Column<string>(type: "TEXT", nullable: true),
                    IsCancelled = table.Column<bool>(type: "INTEGER", nullable: false)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestBookings",
                columns: table => new
                {
                    GuestBookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuestId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    HasAttended = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCancelled = table.Column<bool>(type: "INTEGER", nullable: false)
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
                columns: new[] { "EventId", "Date", "EndTime", "EventType", "IsCancelled", "StartTime", "Title", "VenueReference" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:00:00", "EXH", false, "09:00:00", "Tech Expo", "Test" },
                    { 2, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "15:00:00", "WKS", false, "10:00:00", "AI Workshop", null },
                    { 3, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "23:00:00", "GAL", false, "19:00:00", "Annual Gala Dinner", null },
                    { 4, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "18:00:00", "CMP", false, "09:00:00", "Coding Hackathon", null },
                    { 5, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:30:00", "OTR", false, "08:30:00", "Marketing Summit", null },
                    { 6, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "20:00:00", "CMP", false, "14:00:00", "Startup Pitch Fest", null },
                    { 7, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:00:00", "EXH", false, "10:00:00", "Science Fair", null },
                    { 8, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "22:00:00", "FND", false, "18:00:00", "Charity Auction", null },
                    { 9, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:00:00", "WKS", false, "13:00:00", "Photography Workshop", null },
                    { 10, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "18:00:00", "EXH", false, "10:00:00", "Art & Design Expo", null },
                    { 11, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "21:30:00", "NET", false, "19:00:00", "Developer Meetup", null },
                    { 12, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "15:00:00", "OTR", false, "09:00:00", "Community Volunteering", null },
                    { 13, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "22:00:00", "FES", false, "14:00:00", "Holiday Festival", null },
                    { 14, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:30:00", "WKS", false, "09:30:00", "Leadership Seminar", null },
                    { 15, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "23:59:00", "FES", false, "20:00:00", "End-of-Year Party", null }
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "GuestId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "alice.johnson@example.com", "Alice Johnson", "07412345678" },
                    { 2, "bob.smith@example.com", "Bob Smith", "07323456789" },
                    { 3, "charlie.brown@example.com", "Charlie Brown", "07734567890" },
                    { 4, "diana.prince@example.com", "Diana Prince", "07845678901" },
                    { 5, "eve.adams@example.com", "Eve Adams", "07956789012" },
                    { 6, "frank.harris@example.com", "Frank Harris", "07467890123" },
                    { 7, "grace.lee@example.com", "Grace Lee", "07378901234" },
                    { 8, "hank.hill@example.com", "Hank Hill", "07789012345" },
                    { 9, "ivy.nguyen@example.com", "Ivy Nguyen", "07890123456" },
                    { 10, "jack.miller@example.com", "Jack Miller", "07901234567" },
                    { 11, "kelly.green@example.com", "Kelly Green", "07411223344" },
                    { 12, "luke.skywalker@example.com", "Luke Skywalker", "07322334455" },
                    { 13, "maria.garcia@example.com", "Maria Garcia", "07733445566" },
                    { 14, "nathan.drake@example.com", "Nathan Drake", "07844556677" },
                    { 15, "olivia.king@example.com", "Olivia King", "07955667788" },
                    { 16, "paul.walker@example.com", "Paul Walker", "07466778899" },
                    { 17, "quincy.adams@example.com", "Quincy Adams", "07377889900" },
                    { 18, "rachel.scott@example.com", "Rachel Scott", "07788990011" },
                    { 19, "samuel.jackson@example.com", "Samuel Jackson", "07899001122" },
                    { 20, "tina.turner@example.com", "Tina Turner", "07900112233" },
                    { 21, "ulysses.grant@example.com", "Ulysses Grant", "07411223344" },
                    { 22, "victor.hugo@example.com", "Victor Hugo", "07322334455" },
                    { 23, "wendy.darling@example.com", "Wendy Darling", "07733445566" },
                    { 24, "xander.cage@example.com", "Xander Cage", "07844556677" },
                    { 25, "yasmine.lopez@example.com", "Yasmine Lopez", "07955667788" },
                    { 26, "zack.morris@example.com", "Zack Morris", "07466778899" },
                    { 27, "aaron.paul@example.com", "Aaron Paul", "07377889900" },
                    { 28, "beatrice.potter@example.com", "Beatrice Potter", "07788990011" },
                    { 29, "catherine.zeta@example.com", "Catherine Zeta", "07899001122" },
                    { 30, "david.beckham@example.com", "David Beckham", "07900112233" },
                    { 31, "elaine.benes@example.com", "Elaine Benes", "07411223344" },
                    { 32, "freddie.mercury@example.com", "Freddie Mercury", "07322334455" },
                    { 33, "george.clooney@example.com", "George Clooney", "07733445566" },
                    { 34, "helen.mirren@example.com", "Helen Mirren", "07844556677" },
                    { 35, "ian.mckellen@example.com", "Ian McKellen", "07955667788" },
                    { 36, "jessica.alba@example.com", "Jessica Alba", "07466778899" },
                    { 37, "kevin.hart@example.com", "Kevin Hart", "07377889900" },
                    { 38, "lana.del.rey@example.com", "Lana Del Rey", "07788990011" },
                    { 39, "michael.jordan@example.com", "Michael Jordan", "07899001122" },
                    { 40, "nancy.drew@example.com", "Nancy Drew", "07900112233" },
                    { 41, "oscar.wilde@example.com", "Oscar Wilde", "07411223344" },
                    { 42, "penelope.cruz@example.com", "Penelope Cruz", "07322334455" },
                    { 43, "quentin.tarantino@example.com", "Quentin Tarantino", "07733445566" },
                    { 44, "ryan.gosling@example.com", "Ryan Gosling", "07844556677" },
                    { 45, "scarlett.johansson@example.com", "Scarlett Johansson", "07955667788" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "Anna White", "Manager" },
                    { 2, "Ben Thomas", "Manager" },
                    { 3, "Cathy Holmes", "Manager" },
                    { 4, "David Chen", "Manager" },
                    { 5, "Emily Brown", "Manager" },
                    { 6, "Fred Johnson", "Manager" },
                    { 7, "George Lee", "Manager" },
                    { 8, "Helen Davis", "Manager" },
                    { 9, "Irene Scott", "Manager" },
                    { 10, "Jackie Ray", "Manager" },
                    { 11, "Kevin Moore", "Manager" },
                    { 12, "Lily Green", "Manager" },
                    { 13, "Mike Taylor", "Manager" },
                    { 14, "Nina Brooks", "Manager" },
                    { 15, "Oscar Peterson", "Manager" },
                    { 16, "Patricia Ward", "Manager" },
                    { 17, "Quincy Adams", "Manager" },
                    { 18, "Rachel King", "Manager" },
                    { 19, "Samuel Turner", "Manager" },
                    { 20, "Tina Evans", "Manager" },
                    { 21, "Uma Patel", "Assistant" },
                    { 22, "Victor Stone", "Assistant" },
                    { 23, "Wendy Clark", "Assistant" },
                    { 24, "Xavier Lewis", "Assistant" },
                    { 25, "Yvonne Carter", "Assistant" },
                    { 26, "Zachary Morgan", "Assistant" },
                    { 27, "Alan Fisher", "Assistant" },
                    { 28, "Betty Reid", "Assistant" },
                    { 29, "Carl Young", "Assistant" },
                    { 30, "Diana Holt", "Assistant" },
                    { 31, "Evan Lee", "Assistant" },
                    { 32, "Fiona Grant", "Assistant" },
                    { 33, "Gordon Blake", "Assistant" },
                    { 34, "Hannah Mills", "Assistant" },
                    { 35, "Ian Cooper", "Assistant" },
                    { 36, "Jenna Foster", "Assistant" },
                    { 37, "Kyle Brown", "Assistant" },
                    { 38, "Laura White", "Assistant" },
                    { 39, "Martin Smith", "Assistant" },
                    { 40, "Nancy Clark", "Assistant" },
                    { 41, "Oliver Harris", "Assistant" },
                    { 42, "Paula Cook", "Assistant" },
                    { 43, "Quentin Brooks", "Assistant" },
                    { 44, "Rachel Adams", "Assistant" },
                    { 45, "Simon Lewis", "Assistant" },
                    { 46, "Tina Ford", "Assistant" },
                    { 47, "Uma West", "Assistant" },
                    { 48, "Victor Hall", "Assistant" },
                    { 49, "Wendy Morris", "First Aider" },
                    { 50, "Xander Price", "First Aider" },
                    { 51, "Yasmine Stone", "First Aider" },
                    { 52, "Zara Lloyd", "First Aider" },
                    { 53, "Aaron Jenkins", "First Aider" },
                    { 54, "Bethany Hill", "First Aider" },
                    { 55, "Chris Parker", "First Aider" },
                    { 56, "Donna Evans", "First Aider" },
                    { 57, "Elliot Hayes", "First Aider" },
                    { 58, "Felicity Ross", "First Aider" },
                    { 59, "George Carter", "First Aider" },
                    { 60, "Heather Turner", "First Aider" }
                });

            migrationBuilder.InsertData(
                table: "GuestBookings",
                columns: new[] { "GuestBookingId", "EventId", "GuestId", "HasAttended", "IsCancelled" },
                values: new object[,]
                {
                    { 1, 1, 1, false, false },
                    { 2, 1, 15, true, false },
                    { 3, 1, 7, true, false },
                    { 4, 2, 2, true, false },
                    { 5, 2, 12, false, false },
                    { 6, 2, 15, true, false },
                    { 7, 3, 3, false, false },
                    { 8, 3, 8, true, false },
                    { 9, 4, 4, true, false },
                    { 10, 4, 9, false, false },
                    { 11, 5, 5, false, false },
                    { 12, 5, 10, true, false },
                    { 13, 5, 6, true, false },
                    { 14, 6, 6, true, false },
                    { 15, 6, 13, false, false },
                    { 16, 7, 7, false, false },
                    { 17, 7, 14, true, false },
                    { 18, 8, 8, true, false },
                    { 19, 8, 11, false, false },
                    { 20, 9, 9, false, false },
                    { 21, 9, 15, true, false },
                    { 22, 10, 10, true, false },
                    { 23, 10, 5, false, false },
                    { 24, 11, 11, false, false },
                    { 25, 11, 1, true, false },
                    { 26, 12, 12, true, false },
                    { 27, 12, 4, false, false },
                    { 28, 13, 13, false, false },
                    { 29, 13, 2, true, false },
                    { 30, 14, 14, true, false },
                    { 31, 14, 3, false, false },
                    { 32, 15, 15, true, false },
                    { 33, 15, 1, true, false },
                    { 34, 1, 16, false, false },
                    { 35, 2, 18, true, false },
                    { 36, 3, 17, false, false },
                    { 37, 4, 19, true, false },
                    { 38, 5, 20, true, false },
                    { 39, 6, 21, false, false },
                    { 40, 7, 22, true, false },
                    { 41, 8, 23, false, false },
                    { 42, 9, 24, true, false },
                    { 43, 10, 25, true, false },
                    { 44, 11, 26, false, false },
                    { 45, 12, 27, true, false },
                    { 46, 13, 28, false, false },
                    { 47, 14, 29, true, false },
                    { 48, 15, 30, true, false }
                });

            migrationBuilder.InsertData(
                table: "Staffing",
                columns: new[] { "StaffingId", "EventId", "StaffId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 21 },
                    { 3, 1, 22 },
                    { 4, 2, 2 },
                    { 5, 2, 23 },
                    { 6, 3, 3 },
                    { 7, 3, 24 },
                    { 8, 3, 25 },
                    { 9, 4, 4 },
                    { 10, 4, 26 },
                    { 11, 5, 5 },
                    { 12, 6, 6 },
                    { 13, 6, 27 },
                    { 14, 7, 7 },
                    { 15, 7, 28 },
                    { 16, 7, 29 },
                    { 17, 8, 8 },
                    { 18, 9, 9 },
                    { 19, 9, 30 },
                    { 20, 10, 10 },
                    { 21, 11, 11 },
                    { 22, 11, 31 },
                    { 23, 12, 12 },
                    { 24, 13, 13 },
                    { 25, 13, 32 },
                    { 26, 14, 14 },
                    { 27, 14, 33 },
                    { 28, 15, 15 },
                    { 29, 15, 34 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GuestBookings");

            migrationBuilder.DropTable(
                name: "Staffing");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
