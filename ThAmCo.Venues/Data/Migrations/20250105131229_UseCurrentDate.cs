using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Venues.Data.Migrations
{
    /// <inheritdoc />
    public partial class UseCurrentDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 3, nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Code = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VenueCode = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 5, nullable: false),
                    CostPerHour = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => new { x.Date, x.VenueCode });
                    table.ForeignKey(
                        name: "FK_Availabilities_Venues_VenueCode",
                        column: x => x.VenueCode,
                        principalTable: "Venues",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suitabilities",
                columns: table => new
                {
                    EventTypeId = table.Column<string>(type: "TEXT", fixedLength: true, nullable: false),
                    VenueCode = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suitabilities", x => new { x.EventTypeId, x.VenueCode });
                    table.ForeignKey(
                        name: "FK_Suitabilities_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suitabilities_Venues_VenueCode",
                        column: x => x.VenueCode,
                        principalTable: "Venues",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Reference = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 13, nullable: false),
                    EventDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VenueCode = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 5, nullable: false),
                    WhenMade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StaffId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Reference);
                    table.ForeignKey(
                        name: "FK_Reservations_Availabilities_EventDate_VenueCode",
                        columns: x => new { x.EventDate, x.VenueCode },
                        principalTable: "Availabilities",
                        principalColumns: new[] { "Date", "VenueCode" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "CMP", "Competition" },
                    { "EXH", "Exhibition" },
                    { "FES", "Festival" },
                    { "FND", "Fundraiser" },
                    { "GAL", "Gala" },
                    { "NET", "Networking" },
                    { "OTR", "Outreach" },
                    { "WKS", "Workshop" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Code", "Capacity", "Description", "Name" },
                values: new object[,]
                {
                    { "BLKTW", 100, "Facility for workshops and exhibitions.", "Blackthorn Workshop" },
                    { "BRCHH", 350, "Charming venue surrounded by birch woods.", "Birch Hall" },
                    { "CMPGR", 800, "Purpose-built grounds for hosting competitions.", "Competition Grounds" },
                    { "CRKHL", 150, "Once the residence of Lord and Lady Crackling.", "Crackling Hall" },
                    { "ELMRG", 150, "Picturesque gardens ideal for fundraisers.", "Elm Ridge Gardens" },
                    { "FDLCK", 85, "Rustic pub in idyllic countryside.", "The Fiddler's Cockatoo" },
                    { "GLTNK", 400, "Fundraiser venue with underwater gallery.", "Glisten Tank" },
                    { "HMSCR", 250, "Exhibition space for home innovations.", "HomeScape Cradle" },
                    { "HNTWM", 450, "Countryside estate for high-profile galas.", "Huntwick Manor" },
                    { "LNKRY", 300, "Modern networking venue with high-speed internet.", "The Linkery" },
                    { "MNSYN", 100, "Rustic tavern known for its festive atmosphere.", "Moonshine Inn" },
                    { "RIVPT", 600, "Perfect for outdoor gatherings by the river.", "Riverpoint Terrace" },
                    { "SLTCR", 200, "Quiet and serene location ideal for outreach.", "Saltmarsh Retreat" },
                    { "SPHRD", 500, "Waterside venue great for festivals and exhibitions.", "Sapphire Docks" },
                    { "STGHM", 500, "Historical gala venue with starry ceilings.", "Stargaze Hall" },
                    { "STPFL", 400, "Multipurpose space for conferences and exhibitions.", "Stepfield Hall" },
                    { "SUNPL", 1200, "Spacious waterfront venue.", "Sunset Pavilion" },
                    { "TNDMR", 450, "Refurbished manor house with equipped facilities.", "Tinder Manor" },
                    { "WDRSC", 700, "Castle with a history of hosting royal galas.", "Woodrose Castle" },
                    { "WTHTR", 220, "Theatre for festivals and cultural events.", "Willow Theatre" }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Date", "VenueCode", "CostPerHour" },
                values: new object[,]
                {
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 38.530000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 45.890000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 100.51000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.310000000000002 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 54.490000000000002 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.609999999999999 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 144.81999999999999 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 82.280000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 77.510000000000005 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 116.25 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 40.93 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 112.55 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 64.989999999999995 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 164.27000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 154.30000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 107.88 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 215.37 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.129999999999995 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 136.90000000000001 },
                    { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 106.76000000000001 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 60.520000000000003 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 62.5 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 136.09 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 90.870000000000005 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 81.189999999999998 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.600000000000001 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 112.56999999999999 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 101.55 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 126.88 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 77.700000000000003 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 43.890000000000001 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 120.73999999999999 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 48.740000000000002 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 157.30000000000001 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 85.319999999999993 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 106.58 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 160.46000000000001 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.37 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 219.5 },
                    { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 102.40000000000001 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 60.149999999999999 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 81.719999999999999 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 185.05000000000001 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.400000000000006 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 99.530000000000001 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.920000000000002 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 179.74000000000001 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 88.719999999999999 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 84.090000000000003 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 91.370000000000005 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 75.120000000000005 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 167.87 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 75.810000000000002 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 124.16 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 152.00999999999999 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 81.400000000000006 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 174.87 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 139.66999999999999 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 177.16 },
                    { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 100.94 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 39.390000000000001 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 54.119999999999997 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 106.23 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.909999999999997 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 93.659999999999997 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.659999999999997 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 141.18000000000001 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 60.729999999999997 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 89.620000000000005 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 99.799999999999997 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 68.430000000000007 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 160.31 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 75.859999999999999 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 183.72 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 134.28 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 114.39 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 137.62 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 117.40000000000001 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 110.2 },
                    { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 108.70999999999999 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 66.680000000000007 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 86.109999999999999 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 128.16 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.299999999999997 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 76.980000000000004 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.280000000000001 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 95.709999999999994 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 95.829999999999998 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 112.23999999999999 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 79.959999999999994 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 75.689999999999998 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 167.69999999999999 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 43.460000000000001 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 185.96000000000001 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 87.519999999999996 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 108.73 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 146.56 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.019999999999996 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 218.18000000000001 },
                    { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 129.65000000000001 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 41.619999999999997 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 46.329999999999998 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 170.5 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.939999999999998 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 56.880000000000003 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.890000000000001 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 113.73 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 77.099999999999994 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 118.59999999999999 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 77.200000000000003 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 66.049999999999997 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 106.69 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 73.540000000000006 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 144.74000000000001 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 91.930000000000007 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 92.019999999999996 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 169.21000000000001 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.18000000000001 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 215.80000000000001 },
                    { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 84.609999999999999 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 51.689999999999998 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 67.930000000000007 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 195.86000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.299999999999997 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 50.100000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.91 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 165.83000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 106.34 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 94.620000000000005 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 109.23999999999999 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 50.210000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 96.239999999999995 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 46.810000000000002 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 190.71000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 88.560000000000002 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 87.5 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 206.25 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.36000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 127.29000000000001 },
                    { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 69.189999999999998 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 53.93 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 88.329999999999998 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 198.88 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.109999999999999 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 77.870000000000005 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 41.43 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 141.13 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 62.189999999999998 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 98.280000000000001 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 73.349999999999994 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 50.590000000000003 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 161.27000000000001 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 65.760000000000005 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 180.31999999999999 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 128.78999999999999 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 126.04000000000001 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 194.38 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 139.43000000000001 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 194.94999999999999 },
                    { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 95.269999999999996 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 46.390000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 89.709999999999994 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 138.71000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.879999999999995 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 83.609999999999999 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.289999999999999 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 148.13999999999999 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 93.480000000000004 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 93.159999999999997 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 71.209999999999994 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 58.960000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 100.15000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 73.069999999999993 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 146.02000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 156.24000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 102.20999999999999 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 178.56 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.280000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 120.04000000000001 },
                    { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 96.400000000000006 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 58.490000000000002 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 45.759999999999998 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 152.27000000000001 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.689999999999998 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 68.959999999999994 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.719999999999999 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 136.47 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 88.849999999999994 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 133.81 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 64.109999999999999 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 47.840000000000003 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 160.05000000000001 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 48.770000000000003 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 134.05000000000001 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 119.25 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 134.50999999999999 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 143.38999999999999 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.0 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 131.0 },
                    { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 79.060000000000002 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 51.390000000000001 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 74.409999999999997 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 128.03 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.599999999999994 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 93.310000000000002 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.149999999999999 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 177.31 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 100.68000000000001 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 84.980000000000004 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 97.480000000000004 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 75.5 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 131.30000000000001 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 80.0 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 177.81 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 91.840000000000003 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 93.620000000000005 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 225.38 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.84 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 116.88 },
                    { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 69.659999999999997 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 64.170000000000002 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 57.520000000000003 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 150.66 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.370000000000005 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 66.25 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.479999999999997 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 96.989999999999995 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 92.680000000000007 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 120.94 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 101.58 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 59.659999999999997 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 151.72999999999999 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 59.25 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 142.69 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 134.21000000000001 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 83.459999999999994 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 219.05000000000001 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 135.38 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 122.11 },
                    { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 79.969999999999999 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 63.32 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 88.519999999999996 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 153.16 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.629999999999995 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 89.329999999999998 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.57 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 136.16999999999999 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 86.340000000000003 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 116.95 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 97.819999999999993 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 65.510000000000005 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 128.69 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 66.090000000000003 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 164.72 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 125.59 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 80.519999999999996 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 208.25 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.13 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 190.61000000000001 },
                    { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 74.799999999999997 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 62.780000000000001 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 71.450000000000003 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 105.7 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.480000000000004 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 76.0 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.200000000000003 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 104.02 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 64.5 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 124.17 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 115.66 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 52.789999999999999 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 114.95 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 68.790000000000006 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 199.90000000000001 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 98.030000000000001 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 116.29000000000001 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 222.99000000000001 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.28 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 121.20999999999999 },
                    { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 94.049999999999997 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "BLKTW", 61.759999999999998 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRCHH", 79.75 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CMPGR", 128.06 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.109999999999999 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELMRG", 91.480000000000004 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.210000000000001 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "GLTNK", 163.22999999999999 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "HMSCR", 65.150000000000006 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "HNTWM", 100.58 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "LNKRY", 73.280000000000001 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "MNSYN", 54.759999999999998 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "RIVPT", 169.30000000000001 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLTCR", 72.379999999999995 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPHRD", 160.88999999999999 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "STGHM", 129.44999999999999 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "STPFL", 84.370000000000005 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUNPL", 201.56999999999999 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.680000000000007 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDRSC", 202.38 },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTHTR", 94.319999999999993 }
                });

            migrationBuilder.InsertData(
                table: "Suitabilities",
                columns: new[] { "EventTypeId", "VenueCode" },
                values: new object[,]
                {
                    { "CMP", "CMPGR" },
                    { "EXH", "CRKHL" },
                    { "EXH", "HMSCR" },
                    { "EXH", "STPFL" },
                    { "EXH", "SUNPL" },
                    { "FES", "RIVPT" },
                    { "FES", "SPHRD" },
                    { "FES", "SUNPL" },
                    { "FES", "WTHTR" },
                    { "FND", "ELMRG" },
                    { "FND", "FDLCK" },
                    { "FND", "GLTNK" },
                    { "FND", "MNSYN" },
                    { "GAL", "CRKHL" },
                    { "GAL", "HNTWM" },
                    { "GAL", "STGHM" },
                    { "GAL", "WDRSC" },
                    { "NET", "LNKRY" },
                    { "NET", "TNDMR" },
                    { "OTR", "SLTCR" },
                    { "WKS", "BLKTW" },
                    { "WKS", "BRCHH" },
                    { "WKS", "TNDMR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_VenueCode",
                table: "Availabilities",
                column: "VenueCode");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EventDate_VenueCode",
                table: "Reservations",
                columns: new[] { "EventDate", "VenueCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suitabilities_VenueCode",
                table: "Suitabilities",
                column: "VenueCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Suitabilities");

            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}
