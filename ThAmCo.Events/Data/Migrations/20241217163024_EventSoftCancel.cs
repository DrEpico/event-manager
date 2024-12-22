using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class EventSoftCancel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                column: "IsCancelled",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Events");
        }
    }
}
