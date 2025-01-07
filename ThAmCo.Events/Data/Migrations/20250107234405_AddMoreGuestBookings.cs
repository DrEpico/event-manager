using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreGuestBookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 2,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 3,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 1, 7, true });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 4,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 5,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 6,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 7,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 8,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 9,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 4, 4, true });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 10,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 4, 9, false });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 11,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 12,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 13,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 5, 6, true });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 14,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 15,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 16,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 7, 7, false });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 17,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 7, 14 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 18,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 8, 8 });

            migrationBuilder.InsertData(
                table: "GuestBookings",
                columns: new[] { "GuestBookingId", "EventId", "GuestId", "HasAttended", "IsCancelled" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 2,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 3,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 3, 3, false });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 4,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 5,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 6,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 7,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 8,
                column: "EventId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 9,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 9, 9, false });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 10,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 10, 10, true });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 11,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 12,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 12, 12 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 13,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 13, 13, false });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 14,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 14, 14 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 15,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 15, 15 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 16,
                columns: new[] { "EventId", "GuestId", "HasAttended" },
                values: new object[] { 1, 15, true });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 17,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 18,
                columns: new[] { "EventId", "GuestId" },
                values: new object[] { 15, 1 });
        }
    }
}
