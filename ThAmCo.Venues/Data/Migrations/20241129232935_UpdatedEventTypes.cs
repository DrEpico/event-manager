using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Venues.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEventTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "CON", "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "CON", "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "MET", "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "PTY", "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "PTY", "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "WED", "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "WED", "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "WED", "TNDMR" });

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "CON");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "MET");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "PTY");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "WED");

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "COMP", "Competition" },
                    { "EXH", "Exhibition" },
                    { "FES", "Festival" },
                    { "FND", "Fundraiser" },
                    { "GAL", "Gala" },
                    { "NET", "Networking" },
                    { "OTR", "Outreach" },
                    { "WKS", "Workshop" }
                });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "FDLCK",
                column: "Description",
                value: "Rustic pub set in idyllic countryside, the original venue of a notorious local musician and his parrot.");

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Code", "Capacity", "Description", "Name" },
                values: new object[,]
                {
                    { "BLKTW", 100, "An innovative facility equipped for hands-on workshops and small exhibitions.", "Blackthorn Workshop" },
                    { "CMPGR", 800, "Purpose-built grounds for hosting local and national competitions.", "Competition Grounds" },
                    { "GLTNK", 400, "A fundraiser venue featuring an underwater observation gallery.", "Glisten Tank" },
                    { "HMSCR", 250, "A unique exhibition space for showcasing home and garden innovations.", "HomeScape Cradle" },
                    { "LNKRY", 300, "A modern networking venue with high-speed internet and breakout rooms.", "The Linkery" },
                    { "SLTCR", 200, "A quiet and serene location ideal for outreach and nature-focused events.", "Saltmarsh Retreat" },
                    { "STGHM", 500, "A historical gala venue known for its starry ceilings and lavish interiors.", "Stargaze Hall" },
                    { "SUNPL", 1200, "A spacious venue by the waterfront, perfect for festivals and large gatherings.", "Sunset Pavilion" },
                    { "WTHTR", 220, "A charming theatre perfect for cultural festivals and performances.", "Willow Theatre" }
                });

            migrationBuilder.InsertData(
                table: "Suitabilities",
                columns: new[] { "EventTypeId", "VenueCode" },
                values: new object[,]
                {
                    { "COMP", "CMPGR" },
                    { "COMP", "TNDMR" },
                    { "EXH", "BLKTW" },
                    { "EXH", "CMPGR" },
                    { "EXH", "CRKHL" },
                    { "EXH", "HMSCR" },
                    { "EXH", "SUNPL" },
                    { "EXH", "WTHTR" },
                    { "FES", "SUNPL" },
                    { "FES", "WTHTR" },
                    { "FND", "CRKHL" },
                    { "FND", "FDLCK" },
                    { "FND", "GLTNK" },
                    { "FND", "HMSCR" },
                    { "GAL", "CRKHL" },
                    { "GAL", "STGHM" },
                    { "MET", "LNKRY" },
                    { "NET", "LNKRY" },
                    { "NET", "TNDMR" },
                    { "OTR", "FDLCK" },
                    { "OTR", "SLTCR" },
                    { "WKS", "BLKTW" },
                    { "WKS", "SLTCR" },
                    { "WKS", "TNDMR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "COMP", "CMPGR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "COMP", "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "EXH", "BLKTW" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "EXH", "CMPGR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "EXH", "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "EXH", "HMSCR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "EXH", "SUNPL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "EXH", "WTHTR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "FES", "SUNPL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "FES", "WTHTR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "FND", "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "FND", "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "FND", "GLTNK" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "FND", "HMSCR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "GAL", "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "GAL", "STGHM" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "MET", "LNKRY" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "NET", "LNKRY" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "NET", "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "OTR", "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "OTR", "SLTCR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "WKS", "BLKTW" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "WKS", "SLTCR" });

            migrationBuilder.DeleteData(
                table: "Suitabilities",
                keyColumns: new[] { "EventTypeId", "VenueCode" },
                keyValues: new object[] { "WKS", "TNDMR" });

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "COMP");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "EXH");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "FES");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "FND");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "GAL");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "NET");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "OTR");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: "WKS");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "BLKTW");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "CMPGR");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "GLTNK");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "HMSCR");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "LNKRY");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "SLTCR");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "STGHM");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "SUNPL");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "WTHTR");

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "CON", "Conference" },
                    { "MET", "Meeting" },
                    { "PTY", "Party" },
                    { "WED", "Wedding" }
                });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Code",
                keyValue: "FDLCK",
                column: "Description",
                value: "Rustic pub set in ideallic countryside, the original venue of a notorious local musician and his parrot.");

            migrationBuilder.InsertData(
                table: "Suitabilities",
                columns: new[] { "EventTypeId", "VenueCode" },
                values: new object[,]
                {
                    { "CON", "CRKHL" },
                    { "CON", "TNDMR" },
                    { "MET", "TNDMR" },
                    { "PTY", "CRKHL" },
                    { "PTY", "FDLCK" },
                    { "WED", "CRKHL" },
                    { "WED", "FDLCK" },
                    { "WED", "TNDMR" }
                });
        }
    }
}
