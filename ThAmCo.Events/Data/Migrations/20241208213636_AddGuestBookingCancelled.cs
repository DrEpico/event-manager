using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddGuestBookingCancelled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "GuestBookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 1,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 2,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 3,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 4,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 5,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 6,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 7,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 8,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 9,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 10,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 11,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 12,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 13,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 14,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 15,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 16,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 17,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "GuestBookings",
                keyColumn: "GuestBookingId",
                keyValue: 18,
                column: "IsCancelled",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "GuestBookings");
        }
    }
}
