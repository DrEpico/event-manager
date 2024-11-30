using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class DetailedTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 23, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 21, 30, 0, 0), new TimeSpan(0, 19, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 9, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeSpan(0, 23, 59, 0, 0), new TimeSpan(0, 20, 0, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Events");
        }
    }
}
