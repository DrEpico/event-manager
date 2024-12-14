using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEventsAndStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventType",
                value: "EXH");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventType",
                value: "WKS");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventType",
                value: "GAL");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventType",
                value: "CMP");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventType",
                value: "OTR");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "EventType",
                value: "CMP");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "EventType",
                value: "EXH");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "EventType",
                value: "FND");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "EventType",
                value: "WKS");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "EventType",
                value: "EXH");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "EventType",
                value: "NET");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "EventType",
                value: "OTR");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "EventType",
                value: "FES");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "EventType",
                value: "WKS");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "EventType",
                value: "FES");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 12,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 13,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 15,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 16,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 18,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 19,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 22,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 23,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 25,
                column: "Role",
                value: "Assistant");

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "Name", "Role" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 60);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventType",
                value: "Exhibition");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventType",
                value: "Workshop");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventType",
                value: "Gala");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventType",
                value: "Competition");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventType",
                value: "Conference");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "EventType",
                value: "Competition");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "EventType",
                value: "Exhibition");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "EventType",
                value: "Fundraiser");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "EventType",
                value: "Workshop");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "EventType",
                value: "Exhibition");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "EventType",
                value: "Networking");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "EventType",
                value: "Outreach");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "EventType",
                value: "Festival");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "EventType",
                value: "Workshop");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "EventType",
                value: "Festival");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 12,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 13,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 15,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 16,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 18,
                column: "Role",
                value: "Assistant");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 19,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 22,
                column: "Role",
                value: "Coordinator");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 23,
                column: "Role",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 25,
                column: "Role",
                value: "Coordinator");
        }
    }
}
