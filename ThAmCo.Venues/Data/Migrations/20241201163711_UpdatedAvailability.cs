using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Venues.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Date", "VenueCode", "CostPerHour" },
                values: new object[,]
                {
                    { new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.510000000000005 },
                    { new DateTime(2024, 12, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.819999999999993 },
                    { new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.079999999999998 },
                    { new DateTime(2024, 12, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.879999999999995 },
                    { new DateTime(2024, 12, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.740000000000002 },
                    { new DateTime(2024, 12, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.05 },
                    { new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.230000000000004 },
                    { new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.18 },
                    { new DateTime(2024, 12, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 76.170000000000002 },
                    { new DateTime(2024, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.459999999999994 },
                    { new DateTime(2024, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 122.78 },
                    { new DateTime(2024, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.869999999999997 },
                    { new DateTime(2024, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 52.32 },
                    { new DateTime(2024, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.020000000000003 },
                    { new DateTime(2024, 12, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 70.930000000000007 },
                    { new DateTime(2024, 12, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 107.45 },
                    { new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.91 },
                    { new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.789999999999999 },
                    { new DateTime(2024, 12, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 87.629999999999995 },
                    { new DateTime(2024, 12, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 98.689999999999998 },
                    { new DateTime(2024, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.78 },
                    { new DateTime(2024, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.439999999999998 },
                    { new DateTime(2024, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.759999999999998 },
                    { new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.98 },
                    { new DateTime(2024, 12, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.789999999999999 },
                    { new DateTime(2024, 12, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.020000000000003 },
                    { new DateTime(2024, 12, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.59999999999999 },
                    { new DateTime(2024, 12, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 55.009999999999998 },
                    { new DateTime(2024, 12, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.600000000000001 },
                    { new DateTime(2024, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.579999999999998 },
                    { new DateTime(2024, 12, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.950000000000003 },
                    { new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.5 },
                    { new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.280000000000001 },
                    { new DateTime(2024, 12, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.890000000000001 },
                    { new DateTime(2024, 12, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 107.31 },
                    { new DateTime(2024, 12, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.91 },
                    { new DateTime(2024, 12, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.549999999999997 },
                    { new DateTime(2024, 12, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 41.43 },
                    { new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 87.340000000000003 },
                    { new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.289999999999999 },
                    { new DateTime(2024, 12, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.890000000000001 },
                    { new DateTime(2024, 12, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.040000000000006 },
                    { new DateTime(2024, 12, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.790000000000006 },
                    { new DateTime(2024, 12, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.210000000000001 },
                    { new DateTime(2024, 12, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.780000000000001 },
                    { new DateTime(2024, 12, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.109999999999999 },
                    { new DateTime(2024, 12, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 114.79000000000001 },
                    { new DateTime(2024, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.640000000000001 },
                    { new DateTime(2024, 12, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.299999999999997 },
                    { new DateTime(2024, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.560000000000002 },
                    { new DateTime(2024, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 117.89 },
                    { new DateTime(2024, 12, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.909999999999997 },
                    { new DateTime(2024, 12, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.19 },
                    { new DateTime(2024, 12, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.759999999999998 },
                    { new DateTime(2024, 12, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 114.06 },
                    { new DateTime(2024, 12, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.149999999999999 },
                    { new DateTime(2024, 12, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.75 },
                    { new DateTime(2024, 12, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.939999999999998 },
                    { new DateTime(2024, 12, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 81.829999999999998 },
                    { new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.859999999999999 },
                    { new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.13 },
                    { new DateTime(2024, 12, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.079999999999998 },
                    { new DateTime(2024, 12, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.769999999999996 },
                    { new DateTime(2024, 12, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 67.549999999999997 },
                    { new DateTime(2024, 12, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.849999999999994 },
                    { new DateTime(2024, 12, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.980000000000004 },
                    { new DateTime(2024, 12, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.32 },
                    { new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 97.459999999999994 },
                    { new DateTime(2024, 12, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 60.0 },
                    { new DateTime(2024, 12, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.730000000000004 },
                    { new DateTime(2024, 12, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.590000000000003 },
                    { new DateTime(2024, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.030000000000001 },
                    { new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.770000000000003 },
                    { new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.549999999999997 },
                    { new DateTime(2024, 12, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.770000000000003 },
                    { new DateTime(2024, 12, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.670000000000002 },
                    { new DateTime(2024, 12, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.519999999999996 },
                    { new DateTime(2024, 12, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.920000000000002 },
                    { new DateTime(2024, 12, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.219999999999999 },
                    { new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.770000000000003 },
                    { new DateTime(2024, 12, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.27000000000001 },
                    { new DateTime(2024, 12, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.280000000000001 },
                    { new DateTime(2024, 12, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 82.730000000000004 },
                    { new DateTime(2024, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.739999999999995 },
                    { new DateTime(2024, 12, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.850000000000001 },
                    { new DateTime(2024, 12, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.48 },
                    { new DateTime(2024, 12, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.899999999999999 },
                    { new DateTime(2024, 12, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.979999999999997 },
                    { new DateTime(2024, 12, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.600000000000001 },
                    { new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 55.240000000000002 },
                    { new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.609999999999999 },
                    { new DateTime(2024, 12, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.740000000000002 },
                    { new DateTime(2024, 12, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.030000000000001 },
                    { new DateTime(2024, 12, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.909999999999997 },
                    { new DateTime(2024, 12, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.540000000000006 },
                    { new DateTime(2024, 12, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 88.120000000000005 },
                    { new DateTime(2024, 12, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 52.43 },
                    { new DateTime(2024, 12, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.44 },
                    { new DateTime(2024, 12, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.25 },
                    { new DateTime(2024, 12, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 117.73999999999999 },
                    { new DateTime(2024, 12, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.82 },
                    { new DateTime(2024, 12, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.5 },
                    { new DateTime(2024, 12, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.210000000000001 },
                    { new DateTime(2024, 12, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.310000000000002 },
                    { new DateTime(2024, 12, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.799999999999997 },
                    { new DateTime(2024, 12, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.439999999999998 },
                    { new DateTime(2024, 12, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.100000000000001 },
                    { new DateTime(2024, 12, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.759999999999998 },
                    { new DateTime(2024, 12, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.5 },
                    { new DateTime(2024, 12, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.329999999999998 },
                    { new DateTime(2024, 12, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.549999999999997 },
                    { new DateTime(2024, 12, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.71000000000001 },
                    { new DateTime(2024, 12, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.149999999999999 },
                    { new DateTime(2024, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.719999999999999 },
                    { new DateTime(2024, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.829999999999998 },
                    { new DateTime(2024, 12, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.870000000000001 },
                    { new DateTime(2024, 12, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.61 },
                    { new DateTime(2024, 12, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.149999999999999 },
                    { new DateTime(2024, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.670000000000002 },
                    { new DateTime(2024, 12, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 50.93 },
                    { new DateTime(2024, 12, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 135.36000000000001 },
                    { new DateTime(2024, 12, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.530000000000001 },
                    { new DateTime(2024, 12, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.950000000000003 },
                    { new DateTime(2024, 12, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.5 },
                    { new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.450000000000003 },
                    { new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.880000000000003 },
                    { new DateTime(2024, 12, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.359999999999999 },
                    { new DateTime(2024, 12, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.390000000000001 },
                    { new DateTime(2024, 12, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.709999999999994 },
                    { new DateTime(2024, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.060000000000002 },
                    { new DateTime(2024, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.31999999999999 },
                    { new DateTime(2024, 12, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.359999999999999 },
                    { new DateTime(2024, 12, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.48999999999999 },
                    { new DateTime(2024, 12, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.700000000000003 },
                    { new DateTime(2024, 12, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.090000000000003 },
                    { new DateTime(2024, 12, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 107.04000000000001 },
                    { new DateTime(2024, 12, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.019999999999996 },
                    { new DateTime(2024, 12, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.539999999999999 },
                    { new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.400000000000006 },
                    { new DateTime(2024, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.739999999999995 },
                    { new DateTime(2024, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.65000000000001 },
                    { new DateTime(2024, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.079999999999998 },
                    { new DateTime(2024, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.670000000000002 },
                    { new DateTime(2024, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.280000000000001 },
                    { new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.590000000000003 },
                    { new DateTime(2024, 12, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 67.379999999999995 },
                    { new DateTime(2024, 12, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.680000000000007 },
                    { new DateTime(2024, 12, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.93 },
                    { new DateTime(2024, 12, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.150000000000006 },
                    { new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.079999999999998 },
                    { new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.34999999999999 },
                    { new DateTime(2024, 12, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.530000000000001 },
                    { new DateTime(2024, 12, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.490000000000002 },
                    { new DateTime(2024, 12, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.129999999999995 },
                    { new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.479999999999997 },
                    { new DateTime(2024, 12, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.28 },
                    { new DateTime(2024, 12, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.409999999999997 },
                    { new DateTime(2024, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.280000000000001 },
                    { new DateTime(2024, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.620000000000005 },
                    { new DateTime(2024, 12, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.62 },
                    { new DateTime(2024, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.299999999999997 },
                    { new DateTime(2024, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.039999999999999 },
                    { new DateTime(2024, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.350000000000001 },
                    { new DateTime(2024, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.03 },
                    { new DateTime(2024, 12, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.850000000000001 },
                    { new DateTime(2024, 12, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 132.65000000000001 },
                    { new DateTime(2024, 12, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.969999999999999 },
                    { new DateTime(2024, 12, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.670000000000002 },
                    { new DateTime(2024, 12, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.45999999999999 },
                    { new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.39 },
                    { new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.609999999999999 },
                    { new DateTime(2024, 12, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.189999999999998 },
                    { new DateTime(2024, 12, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.490000000000002 },
                    { new DateTime(2024, 12, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.109999999999999 },
                    { new DateTime(2024, 12, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.420000000000002 },
                    { new DateTime(2024, 12, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 117.73999999999999 },
                    { new DateTime(2024, 12, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.75 },
                    { new DateTime(2024, 12, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.91 },
                    { new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.640000000000001 },
                    { new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 109.31 },
                    { new DateTime(2024, 12, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.25 },
                    { new DateTime(2024, 12, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 137.56999999999999 },
                    { new DateTime(2024, 12, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.609999999999999 },
                    { new DateTime(2024, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.609999999999999 },
                    { new DateTime(2024, 12, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.310000000000002 },
                    { new DateTime(2024, 12, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 103.23 },
                    { new DateTime(2024, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 122.59999999999999 },
                    { new DateTime(2024, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.650000000000006 },
                    { new DateTime(2024, 12, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.780000000000001 },
                    { new DateTime(2024, 12, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.340000000000003 },
                    { new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.299999999999997 },
                    { new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.340000000000003 },
                    { new DateTime(2024, 12, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.109999999999999 },
                    { new DateTime(2024, 12, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.469999999999999 },
                    { new DateTime(2024, 12, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.030000000000001 },
                    { new DateTime(2024, 12, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.939999999999998 },
                    { new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 93.620000000000005 },
                    { new DateTime(2024, 12, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.880000000000003 },
                    { new DateTime(2024, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.630000000000003 },
                    { new DateTime(2024, 12, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.120000000000005 },
                    { new DateTime(2024, 12, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.51000000000001 },
                    { new DateTime(2024, 12, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.420000000000002 },
                    { new DateTime(2024, 12, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 78.269999999999996 },
                    { new DateTime(2024, 12, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.969999999999999 },
                    { new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.719999999999999 },
                    { new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.859999999999999 },
                    { new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.17 },
                    { new DateTime(2024, 12, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.460000000000001 },
                    { new DateTime(2024, 12, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.390000000000001 },
                    { new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.850000000000001 },
                    { new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.959999999999994 },
                    { new DateTime(2024, 12, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.710000000000001 },
                    { new DateTime(2024, 12, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.789999999999999 },
                    { new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.740000000000002 },
                    { new DateTime(2024, 12, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.729999999999997 },
                    { new DateTime(2024, 12, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 89.459999999999994 },
                    { new DateTime(2024, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.520000000000003 },
                    { new DateTime(2024, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 78.719999999999999 },
                    { new DateTime(2024, 12, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.450000000000003 },
                    { new DateTime(2024, 12, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.030000000000001 },
                    { new DateTime(2024, 12, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.040000000000006 },
                    { new DateTime(2024, 12, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.189999999999998 },
                    { new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.069999999999993 },
                    { new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.25 },
                    { new DateTime(2024, 12, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.119999999999997 },
                    { new DateTime(2024, 12, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.5 },
                    { new DateTime(2024, 12, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.8 },
                    { new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.810000000000002 },
                    { new DateTime(2024, 12, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.05000000000001 },
                    { new DateTime(2024, 12, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 56.509999999999998 },
                    { new DateTime(2024, 12, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 134.68000000000001 },
                    { new DateTime(2024, 12, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.170000000000002 },
                    { new DateTime(2024, 12, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.270000000000003 },
                    { new DateTime(2024, 12, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.689999999999998 },
                    { new DateTime(2024, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.719999999999999 },
                    { new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.45999999999999 },
                    { new DateTime(2024, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.069999999999993 },
                    { new DateTime(2024, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.609999999999999 },
                    { new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.170000000000002 },
                    { new DateTime(2024, 12, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.75 },
                    { new DateTime(2024, 12, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 73.019999999999996 },
                    { new DateTime(2024, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.75 },
                    { new DateTime(2024, 12, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.719999999999999 },
                    { new DateTime(2024, 12, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 134.63 },
                    { new DateTime(2024, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.68 },
                    { new DateTime(2024, 12, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 67.109999999999999 },
                    { new DateTime(2024, 12, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.030000000000001 },
                    { new DateTime(2024, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.569999999999993 },
                    { new DateTime(2024, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.439999999999998 },
                    { new DateTime(2024, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.780000000000001 },
                    { new DateTime(2024, 12, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.049999999999997 },
                    { new DateTime(2024, 12, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.629999999999995 },
                    { new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.020000000000003 },
                    { new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.799999999999997 },
                    { new DateTime(2024, 12, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.469999999999999 },
                    { new DateTime(2024, 12, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.77 },
                    { new DateTime(2024, 12, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 138.06 },
                    { new DateTime(2024, 12, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.840000000000003 },
                    { new DateTime(2024, 12, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 111.28 },
                    { new DateTime(2024, 12, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.159999999999997 },
                    { new DateTime(2024, 12, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.209999999999994 },
                    { new DateTime(2024, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 56.399999999999999 },
                    { new DateTime(2024, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.019999999999996 },
                    { new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.280000000000001 },
                    { new DateTime(2024, 12, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.329999999999998 },
                    { new DateTime(2024, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.870000000000005 },
                    { new DateTime(2024, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.039999999999999 },
                    { new DateTime(2024, 12, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.94 },
                    { new DateTime(2024, 12, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.579999999999998 },
                    { new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.869999999999997 },
                    { new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 83.489999999999995 },
                    { new DateTime(2024, 12, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.219999999999999 },
                    { new DateTime(2024, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.219999999999999 },
                    { new DateTime(2024, 12, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.079999999999998 },
                    { new DateTime(2024, 12, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.81999999999999 },
                    { new DateTime(2024, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.25 },
                    { new DateTime(2024, 12, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.5 },
                    { new DateTime(2024, 12, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.920000000000002 },
                    { new DateTime(2024, 12, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.649999999999999 },
                    { new DateTime(2024, 12, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 97.819999999999993 },
                    { new DateTime(2024, 12, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 93.019999999999996 },
                    { new DateTime(2024, 12, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.829999999999998 },
                    { new DateTime(2024, 12, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.109999999999999 },
                    { new DateTime(2024, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.849999999999994 },
                    { new DateTime(2024, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.829999999999998 },
                    { new DateTime(2024, 12, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.700000000000003 },
                    { new DateTime(2024, 12, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.359999999999999 },
                    { new DateTime(2024, 12, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.3 },
                    { new DateTime(2024, 12, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.060000000000002 },
                    { new DateTime(2024, 12, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.56 },
                    { new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.939999999999998 },
                    { new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.15000000000001 },
                    { new DateTime(2024, 12, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.880000000000003 },
                    { new DateTime(2024, 12, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.329999999999998 },
                    { new DateTime(2024, 12, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.590000000000003 },
                    { new DateTime(2024, 12, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.689999999999998 },
                    { new DateTime(2024, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.700000000000003 },
                    { new DateTime(2024, 12, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.130000000000003 },
                    { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.870000000000005 },
                    { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.560000000000002 },
                    { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 135.47999999999999 },
                    { new DateTime(2024, 12, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.519999999999996 },
                    { new DateTime(2024, 12, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.689999999999998 },
                    { new DateTime(2024, 12, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.829999999999998 },
                    { new DateTime(2024, 12, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.890000000000001 },
                    { new DateTime(2024, 12, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.960000000000001 },
                    { new DateTime(2024, 12, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.520000000000003 },
                    { new DateTime(2024, 12, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.420000000000002 },
                    { new DateTime(2024, 12, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.719999999999999 },
                    { new DateTime(2024, 12, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.0 },
                    { new DateTime(2024, 12, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 73.810000000000002 },
                    { new DateTime(2024, 12, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 90.310000000000002 },
                    { new DateTime(2024, 12, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.189999999999998 },
                    { new DateTime(2024, 12, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.219999999999999 },
                    { new DateTime(2024, 12, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.91 },
                    { new DateTime(2024, 12, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 81.879999999999995 },
                    { new DateTime(2024, 12, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.43 },
                    { new DateTime(2024, 12, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.060000000000002 },
                    { new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 103.15000000000001 },
                    { new DateTime(2024, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.240000000000002 },
                    { new DateTime(2024, 12, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.93000000000001 },
                    { new DateTime(2024, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.700000000000003 },
                    { new DateTime(2024, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 74.819999999999993 },
                    { new DateTime(2024, 12, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.670000000000002 },
                    { new DateTime(2024, 12, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 137.52000000000001 },
                    { new DateTime(2024, 12, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 70.040000000000006 },
                    { new DateTime(2024, 12, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.079999999999998 },
                    { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 67.810000000000002 },
                    { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.409999999999997 },
                    { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.769999999999996 },
                    { new DateTime(2024, 12, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.18000000000001 },
                    { new DateTime(2024, 12, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.519999999999996 },
                    { new DateTime(2024, 12, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.260000000000005 },
                    { new DateTime(2024, 12, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.780000000000001 },
                    { new DateTime(2024, 12, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.329999999999998 },
                    { new DateTime(2024, 12, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.43 },
                    { new DateTime(2024, 12, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.989999999999995 },
                    { new DateTime(2024, 12, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.0 },
                    { new DateTime(2024, 12, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.420000000000002 },
                    { new DateTime(2024, 12, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.91 },
                    { new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.57 },
                    { new DateTime(2024, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.549999999999997 },
                    { new DateTime(2024, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.560000000000002 },
                    { new DateTime(2024, 12, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.75 },
                    { new DateTime(2024, 12, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.09 },
                    { new DateTime(2024, 12, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.520000000000003 },
                    { new DateTime(2024, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 68.209999999999994 },
                    { new DateTime(2024, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.140000000000001 },
                    { new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.019999999999996 },
                    { new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.780000000000001 },
                    { new DateTime(2024, 12, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.490000000000002 },
                    { new DateTime(2024, 12, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 82.439999999999998 },
                    { new DateTime(2024, 12, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 109.93000000000001 },
                    { new DateTime(2024, 12, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.270000000000003 },
                    { new DateTime(2024, 12, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.010000000000005 },
                    { new DateTime(2024, 12, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.640000000000001 },
                    { new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.259999999999998 },
                    { new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.810000000000002 },
                    { new DateTime(2024, 12, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.599999999999994 },
                    { new DateTime(2024, 12, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.819999999999993 },
                    { new DateTime(2024, 12, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.480000000000004 },
                    { new DateTime(2024, 12, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.340000000000003 },
                    { new DateTime(2024, 12, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.859999999999999 },
                    { new DateTime(2024, 12, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.83 },
                    { new DateTime(2024, 12, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.670000000000002 },
                    { new DateTime(2024, 12, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.8 },
                    { new DateTime(2024, 12, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.539999999999999 },
                    { new DateTime(2024, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.59 },
                    { new DateTime(2024, 12, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.219999999999999 },
                    { new DateTime(2024, 12, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.420000000000002 },
                    { new DateTime(2024, 12, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.730000000000004 },
                    { new DateTime(2024, 12, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 134.24000000000001 },
                    { new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.780000000000001 },
                    { new DateTime(2024, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 126.72 },
                    { new DateTime(2024, 12, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.049999999999997 },
                    { new DateTime(2024, 12, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.430000000000007 },
                    { new DateTime(2024, 12, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.609999999999999 },
                    { new DateTime(2024, 12, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.959999999999994 },
                    { new DateTime(2024, 12, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.560000000000002 },
                    { new DateTime(2024, 12, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.599999999999994 },
                    { new DateTime(2024, 12, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.62 },
                    { new DateTime(2024, 12, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.079999999999998 },
                    { new DateTime(2024, 12, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.210000000000001 },
                    { new DateTime(2024, 12, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.549999999999997 },
                    { new DateTime(2024, 12, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.489999999999995 },
                    { new DateTime(2024, 12, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.140000000000001 },
                    { new DateTime(2024, 12, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.859999999999999 },
                    { new DateTime(2024, 12, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.170000000000002 },
                    { new DateTime(2024, 12, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.329999999999998 },
                    { new DateTime(2024, 12, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 86.430000000000007 },
                    { new DateTime(2024, 12, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.97 },
                    { new DateTime(2024, 12, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.049999999999997 },
                    { new DateTime(2024, 12, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.710000000000001 },
                    { new DateTime(2024, 12, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.23999999999999 },
                    { new DateTime(2024, 12, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.069999999999993 },
                    { new DateTime(2024, 12, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.75 },
                    { new DateTime(2024, 12, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.559999999999999 },
                    { new DateTime(2024, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 113.51000000000001 },
                    { new DateTime(2024, 12, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.299999999999997 },
                    { new DateTime(2024, 12, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 128.03 },
                    { new DateTime(2024, 12, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.649999999999999 },
                    { new DateTime(2024, 12, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 123.20999999999999 },
                    { new DateTime(2024, 12, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.969999999999999 },
                    { new DateTime(2024, 12, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 121.37 },
                    { new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.969999999999999 },
                    { new DateTime(2024, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.960000000000001 },
                    { new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.380000000000003 },
                    { new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.640000000000001 },
                    { new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.17 },
                    { new DateTime(2024, 12, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 111.08 },
                    { new DateTime(2024, 12, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.849999999999994 },
                    { new DateTime(2024, 12, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.829999999999998 },
                    { new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.719999999999999 },
                    { new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.780000000000001 },
                    { new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.36000000000001 },
                    { new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.310000000000002 },
                    { new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.89 },
                    { new DateTime(2024, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.640000000000001 },
                    { new DateTime(2024, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.469999999999999 },
                    { new DateTime(2024, 12, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.020000000000003 },
                    { new DateTime(2024, 12, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 111.93000000000001 },
                    { new DateTime(2024, 12, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 111.23 },
                    { new DateTime(2024, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.57 },
                    { new DateTime(2024, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 125.48 },
                    { new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.469999999999999 },
                    { new DateTime(2025, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.75 },
                    { new DateTime(2025, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 128.91 },
                    { new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.07 },
                    { new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.630000000000003 },
                    { new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.75 },
                    { new DateTime(2025, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 128.36000000000001 },
                    { new DateTime(2025, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.17 },
                    { new DateTime(2025, 1, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.489999999999995 },
                    { new DateTime(2025, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.92 },
                    { new DateTime(2025, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.390000000000001 },
                    { new DateTime(2025, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.0 },
                    { new DateTime(2025, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.689999999999998 },
                    { new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.730000000000004 },
                    { new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.229999999999997 },
                    { new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.90000000000001 },
                    { new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.490000000000002 },
                    { new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.75 },
                    { new DateTime(2025, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.5 },
                    { new DateTime(2025, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.31999999999999 },
                    { new DateTime(2025, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.560000000000002 },
                    { new DateTime(2025, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.34 },
                    { new DateTime(2025, 1, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.400000000000006 },
                    { new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.100000000000001 },
                    { new DateTime(2025, 1, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.659999999999997 },
                    { new DateTime(2025, 1, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.510000000000005 },
                    { new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.25 },
                    { new DateTime(2025, 1, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 80.280000000000001 },
                    { new DateTime(2025, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.719999999999999 },
                    { new DateTime(2025, 1, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.730000000000004 },
                    { new DateTime(2025, 1, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 109.78 },
                    { new DateTime(2025, 1, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.479999999999997 },
                    { new DateTime(2025, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.289999999999999 },
                    { new DateTime(2025, 1, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.340000000000003 },
                    { new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.599999999999994 },
                    { new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.990000000000002 },
                    { new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.280000000000001 },
                    { new DateTime(2025, 1, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.040000000000006 },
                    { new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.859999999999999 },
                    { new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.46000000000001 },
                    { new DateTime(2025, 1, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.010000000000005 },
                    { new DateTime(2025, 1, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.650000000000006 },
                    { new DateTime(2025, 1, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.25 },
                    { new DateTime(2025, 1, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.75 },
                    { new DateTime(2025, 1, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 139.25 },
                    { new DateTime(2025, 1, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.319999999999993 },
                    { new DateTime(2025, 1, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.37 },
                    { new DateTime(2025, 1, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.84 },
                    { new DateTime(2025, 1, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.030000000000001 },
                    { new DateTime(2025, 1, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.5 },
                    { new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.990000000000002 },
                    { new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.769999999999996 },
                    { new DateTime(2025, 1, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.439999999999998 },
                    { new DateTime(2025, 1, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.040000000000006 },
                    { new DateTime(2025, 1, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.840000000000003 },
                    { new DateTime(2025, 1, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.689999999999998 },
                    { new DateTime(2025, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 68.340000000000003 },
                    { new DateTime(2025, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.13 },
                    { new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.069999999999993 },
                    { new DateTime(2025, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.729999999999997 },
                    { new DateTime(2025, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 109.48999999999999 },
                    { new DateTime(2025, 1, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.200000000000003 },
                    { new DateTime(2025, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.879999999999995 },
                    { new DateTime(2025, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.229999999999997 },
                    { new DateTime(2025, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.14 },
                    { new DateTime(2025, 1, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 111.47 },
                    { new DateTime(2025, 1, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.509999999999998 },
                    { new DateTime(2025, 1, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.790000000000006 },
                    { new DateTime(2025, 1, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.150000000000006 },
                    { new DateTime(2025, 1, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.539999999999999 },
                    { new DateTime(2025, 1, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 122.89 },
                    { new DateTime(2025, 1, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 89.180000000000007 },
                    { new DateTime(2025, 1, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 123.78 },
                    { new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.879999999999995 },
                    { new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 85.260000000000005 },
                    { new DateTime(2025, 1, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.180000000000007 },
                    { new DateTime(2025, 1, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.490000000000002 },
                    { new DateTime(2025, 1, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.88 },
                    { new DateTime(2025, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.880000000000003 },
                    { new DateTime(2025, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 113.45 },
                    { new DateTime(2025, 1, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.180000000000007 },
                    { new DateTime(2025, 1, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 96.430000000000007 },
                    { new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.479999999999997 },
                    { new DateTime(2025, 1, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.689999999999998 },
                    { new DateTime(2025, 1, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.040000000000006 },
                    { new DateTime(2025, 1, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.07 },
                    { new DateTime(2025, 1, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.22999999999999 },
                    { new DateTime(2025, 1, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 56.490000000000002 },
                    { new DateTime(2025, 1, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.840000000000003 },
                    { new DateTime(2025, 1, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.37 },
                    { new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.219999999999999 },
                    { new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 82.040000000000006 },
                    { new DateTime(2025, 1, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.759999999999998 },
                    { new DateTime(2025, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.049999999999997 },
                    { new DateTime(2025, 1, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 74.319999999999993 },
                    { new DateTime(2025, 1, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.859999999999999 },
                    { new DateTime(2025, 1, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.07 },
                    { new DateTime(2025, 1, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.689999999999998 },
                    { new DateTime(2025, 1, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.049999999999997 },
                    { new DateTime(2025, 1, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.70999999999999 },
                    { new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.549999999999997 },
                    { new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.109999999999999 },
                    { new DateTime(2025, 1, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.659999999999997 },
                    { new DateTime(2025, 1, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.15000000000001 },
                    { new DateTime(2025, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 94.049999999999997 },
                    { new DateTime(2025, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.780000000000001 },
                    { new DateTime(2025, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.859999999999999 },
                    { new DateTime(2025, 1, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.77 },
                    { new DateTime(2025, 1, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 123.98 },
                    { new DateTime(2025, 1, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.650000000000006 },
                    { new DateTime(2025, 1, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.340000000000003 },
                    { new DateTime(2025, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 52.890000000000001 },
                    { new DateTime(2025, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.189999999999998 },
                    { new DateTime(2025, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 80.909999999999997 },
                    { new DateTime(2025, 1, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.739999999999995 },
                    { new DateTime(2025, 1, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.259999999999998 },
                    { new DateTime(2025, 1, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.479999999999997 },
                    { new DateTime(2025, 1, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.409999999999997 },
                    { new DateTime(2025, 1, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.400000000000006 },
                    { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.840000000000003 },
                    { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.159999999999997 },
                    { new DateTime(2025, 1, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.75 },
                    { new DateTime(2025, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.670000000000002 },
                    { new DateTime(2025, 1, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.57 },
                    { new DateTime(2025, 1, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 76.390000000000001 },
                    { new DateTime(2025, 1, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.659999999999997 },
                    { new DateTime(2025, 1, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.95 },
                    { new DateTime(2025, 1, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.479999999999997 },
                    { new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.939999999999998 },
                    { new DateTime(2025, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.880000000000003 },
                    { new DateTime(2025, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.569999999999993 },
                    { new DateTime(2025, 1, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.439999999999998 },
                    { new DateTime(2025, 1, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.510000000000005 },
                    { new DateTime(2025, 1, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.200000000000003 },
                    { new DateTime(2025, 1, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.509999999999998 },
                    { new DateTime(2025, 1, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.909999999999997 },
                    { new DateTime(2025, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.109999999999999 },
                    { new DateTime(2025, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.780000000000001 },
                    { new DateTime(2025, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.530000000000001 },
                    { new DateTime(2025, 1, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.390000000000001 },
                    { new DateTime(2025, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.969999999999999 },
                    { new DateTime(2025, 1, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.52000000000001 },
                    { new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.530000000000001 },
                    { new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.599999999999994 },
                    { new DateTime(2025, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.350000000000001 },
                    { new DateTime(2025, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.219999999999999 },
                    { new DateTime(2025, 1, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 98.060000000000002 },
                    { new DateTime(2025, 1, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.270000000000003 },
                    { new DateTime(2025, 1, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.299999999999997 },
                    { new DateTime(2025, 1, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.760000000000005 },
                    { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.650000000000006 },
                    { new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.799999999999997 },
                    { new DateTime(2025, 1, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.640000000000001 },
                    { new DateTime(2025, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.390000000000001 },
                    { new DateTime(2025, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.71000000000001 },
                    { new DateTime(2025, 1, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.69 },
                    { new DateTime(2025, 1, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 114.72 },
                    { new DateTime(2025, 1, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 85.049999999999997 },
                    { new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.909999999999997 },
                    { new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 132.37 },
                    { new DateTime(2025, 1, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.819999999999993 },
                    { new DateTime(2025, 1, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 97.189999999999998 },
                    { new DateTime(2025, 1, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.539999999999999 },
                    { new DateTime(2025, 1, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.090000000000003 },
                    { new DateTime(2025, 1, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.2 },
                    { new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.180000000000007 },
                    { new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.86000000000001 },
                    { new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.82 },
                    { new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 121.84 },
                    { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.83 },
                    { new DateTime(2025, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 123.75 },
                    { new DateTime(2025, 1, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.409999999999997 },
                    { new DateTime(2025, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.090000000000003 },
                    { new DateTime(2025, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 126.7 },
                    { new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 90.159999999999997 },
                    { new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.450000000000003 },
                    { new DateTime(2025, 1, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.959999999999994 },
                    { new DateTime(2025, 1, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.090000000000003 },
                    { new DateTime(2025, 1, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.299999999999997 },
                    { new DateTime(2025, 1, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.33 },
                    { new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.819999999999993 },
                    { new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 93.909999999999997 },
                    { new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.630000000000003 },
                    { new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.990000000000002 },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.079999999999998 },
                    { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 135.13 },
                    { new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 55.5 },
                    { new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.799999999999997 },
                    { new DateTime(2025, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.810000000000002 },
                    { new DateTime(2025, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 83.959999999999994 },
                    { new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.57 },
                    { new DateTime(2025, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.609999999999999 },
                    { new DateTime(2025, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.39 },
                    { new DateTime(2025, 1, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.549999999999997 },
                    { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.649999999999999 },
                    { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.01000000000001 },
                    { new DateTime(2025, 1, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.370000000000005 },
                    { new DateTime(2025, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 103.36 },
                    { new DateTime(2025, 1, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.280000000000001 },
                    { new DateTime(2025, 1, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.439999999999998 },
                    { new DateTime(2025, 1, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.07 },
                    { new DateTime(2025, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.849999999999994 },
                    { new DateTime(2025, 1, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.900000000000006 },
                    { new DateTime(2025, 1, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.39 },
                    { new DateTime(2025, 1, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.329999999999998 },
                    { new DateTime(2025, 1, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 88.75 },
                    { new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.84 },
                    { new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.0 },
                    { new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.449999999999999 },
                    { new DateTime(2025, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.489999999999995 },
                    { new DateTime(2025, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.780000000000001 },
                    { new DateTime(2025, 1, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.969999999999999 },
                    { new DateTime(2025, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.260000000000005 },
                    { new DateTime(2025, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.489999999999995 },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.890000000000001 },
                    { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 107.62 },
                    { new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 89.260000000000005 },
                    { new DateTime(2025, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.06999999999999 },
                    { new DateTime(2025, 1, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.680000000000007 },
                    { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.290000000000006 },
                    { new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.060000000000002 },
                    { new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 125.7 },
                    { new DateTime(2025, 1, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.620000000000005 },
                    { new DateTime(2025, 1, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.540000000000006 },
                    { new DateTime(2025, 1, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.57 },
                    { new DateTime(2025, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 70.060000000000002 },
                    { new DateTime(2025, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.409999999999997 },
                    { new DateTime(2025, 1, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.109999999999999 },
                    { new DateTime(2025, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.380000000000003 },
                    { new DateTime(2025, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.68 },
                    { new DateTime(2025, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.54000000000001 },
                    { new DateTime(2025, 1, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.32 },
                    { new DateTime(2025, 1, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 98.420000000000002 },
                    { new DateTime(2025, 1, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.120000000000005 },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.299999999999997 },
                    { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.380000000000003 },
                    { new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.619999999999997 },
                    { new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 73.150000000000006 },
                    { new DateTime(2025, 1, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 135.21000000000001 },
                    { new DateTime(2025, 1, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.420000000000002 },
                    { new DateTime(2025, 1, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 80.379999999999995 },
                    { new DateTime(2025, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 82.609999999999999 },
                    { new DateTime(2025, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.090000000000003 },
                    { new DateTime(2025, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 81.859999999999999 },
                    { new DateTime(2025, 1, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.950000000000003 },
                    { new DateTime(2025, 1, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.83000000000001 },
                    { new DateTime(2025, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.07 },
                    { new DateTime(2025, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.759999999999998 },
                    { new DateTime(2025, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 137.38999999999999 },
                    { new DateTime(2025, 1, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.640000000000001 },
                    { new DateTime(2025, 1, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.960000000000001 },
                    { new DateTime(2025, 1, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.43 },
                    { new DateTime(2025, 1, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 81.030000000000001 },
                    { new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.359999999999999 },
                    { new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 78.340000000000003 },
                    { new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.769999999999996 },
                    { new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 107.72 },
                    { new DateTime(2025, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.32 },
                    { new DateTime(2025, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.840000000000003 },
                    { new DateTime(2025, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.170000000000002 },
                    { new DateTime(2025, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.100000000000001 },
                    { new DateTime(2025, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.769999999999996 },
                    { new DateTime(2025, 1, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.469999999999999 },
                    { new DateTime(2025, 1, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 126.95999999999999 },
                    { new DateTime(2025, 1, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.66 },
                    { new DateTime(2025, 1, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.049999999999997 },
                    { new DateTime(2025, 1, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.409999999999997 },
                    { new DateTime(2025, 1, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.12 },
                    { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.319999999999993 },
                    { new DateTime(2025, 1, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.19999999999999 },
                    { new DateTime(2025, 1, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.329999999999998 },
                    { new DateTime(2025, 1, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.310000000000002 },
                    { new DateTime(2025, 1, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.799999999999997 },
                    { new DateTime(2025, 1, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.28 },
                    { new DateTime(2025, 1, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.829999999999998 },
                    { new DateTime(2025, 1, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.439999999999998 },
                    { new DateTime(2025, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.460000000000001 },
                    { new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 86.200000000000003 },
                    { new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.259999999999998 },
                    { new DateTime(2025, 1, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.739999999999995 },
                    { new DateTime(2025, 1, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.719999999999999 },
                    { new DateTime(2025, 1, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.859999999999999 },
                    { new DateTime(2025, 1, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.07 },
                    { new DateTime(2025, 1, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.030000000000001 },
                    { new DateTime(2025, 1, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.790000000000006 },
                    { new DateTime(2025, 1, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 132.28999999999999 },
                    { new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.469999999999999 },
                    { new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.82 },
                    { new DateTime(2025, 1, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.770000000000003 },
                    { new DateTime(2025, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.77000000000001 },
                    { new DateTime(2025, 1, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 134.75 },
                    { new DateTime(2025, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.69999999999999 },
                    { new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.990000000000002 },
                    { new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.7 },
                    { new DateTime(2025, 1, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 87.459999999999994 },
                    { new DateTime(2025, 1, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.520000000000003 },
                    { new DateTime(2025, 1, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 128.38 },
                    { new DateTime(2025, 1, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.020000000000003 },
                    { new DateTime(2025, 1, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.340000000000003 },
                    { new DateTime(2025, 1, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.909999999999997 },
                    { new DateTime(2025, 1, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.189999999999998 },
                    { new DateTime(2025, 1, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.84999999999999 },
                    { new DateTime(2025, 1, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.489999999999995 },
                    { new DateTime(2025, 1, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.22 },
                    { new DateTime(2025, 1, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.560000000000002 },
                    { new DateTime(2025, 1, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.739999999999995 },
                    { new DateTime(2025, 1, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.369999999999997 },
                    { new DateTime(2025, 1, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 68.120000000000005 },
                    { new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 87.730000000000004 },
                    { new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 76.640000000000001 },
                    { new DateTime(2025, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.799999999999997 },
                    { new DateTime(2025, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.899999999999999 },
                    { new DateTime(2025, 1, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.590000000000003 },
                    { new DateTime(2025, 1, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.030000000000001 },
                    { new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.400000000000006 },
                    { new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.619999999999997 },
                    { new DateTime(2025, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.07 },
                    { new DateTime(2025, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.97999999999999 },
                    { new DateTime(2025, 1, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.989999999999995 },
                    { new DateTime(2025, 1, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.810000000000002 },
                    { new DateTime(2025, 1, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.050000000000001 },
                    { new DateTime(2025, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.280000000000001 },
                    { new DateTime(2025, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 134.06 },
                    { new DateTime(2025, 1, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 138.5 },
                    { new DateTime(2025, 1, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 103.61 },
                    { new DateTime(2025, 1, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.209999999999994 },
                    { new DateTime(2025, 1, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 125.33 },
                    { new DateTime(2025, 1, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 41.93 },
                    { new DateTime(2025, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.57 },
                    { new DateTime(2025, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.16999999999999 },
                    { new DateTime(2025, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.920000000000002 },
                    { new DateTime(2025, 1, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 94.799999999999997 },
                    { new DateTime(2025, 1, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.5 },
                    { new DateTime(2025, 1, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.609999999999999 },
                    { new DateTime(2025, 1, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.649999999999999 },
                    { new DateTime(2025, 1, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.730000000000004 },
                    { new DateTime(2025, 1, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.869999999999997 },
                    { new DateTime(2025, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.16 },
                    { new DateTime(2025, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.310000000000002 },
                    { new DateTime(2025, 1, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.870000000000005 },
                    { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.920000000000002 },
                    { new DateTime(2025, 1, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 138.40000000000001 },
                    { new DateTime(2025, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.619999999999997 },
                    { new DateTime(2025, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.119999999999997 },
                    { new DateTime(2025, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.09 },
                    { new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.030000000000001 },
                    { new DateTime(2025, 1, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.849999999999994 },
                    { new DateTime(2025, 1, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.310000000000002 },
                    { new DateTime(2025, 1, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.890000000000001 },
                    { new DateTime(2025, 1, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.079999999999998 },
                    { new DateTime(2025, 1, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 126.56999999999999 },
                    { new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.530000000000001 },
                    { new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 97.060000000000002 },
                    { new DateTime(2025, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.409999999999997 },
                    { new DateTime(2025, 1, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.510000000000005 },
                    { new DateTime(2025, 1, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.310000000000002 },
                    { new DateTime(2025, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.06 },
                    { new DateTime(2025, 1, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.32 },
                    { new DateTime(2025, 1, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.5 },
                    { new DateTime(2025, 1, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.269999999999996 },
                    { new DateTime(2025, 1, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.310000000000002 },
                    { new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.480000000000004 },
                    { new DateTime(2025, 1, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.97 },
                    { new DateTime(2025, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.890000000000001 },
                    { new DateTime(2025, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.010000000000002 },
                    { new DateTime(2025, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.540000000000006 },
                    { new DateTime(2025, 1, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.980000000000004 },
                    { new DateTime(2025, 1, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.109999999999999 },
                    { new DateTime(2025, 1, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.25 },
                    { new DateTime(2025, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.109999999999999 },
                    { new DateTime(2025, 1, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 56.619999999999997 },
                    { new DateTime(2025, 1, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.969999999999999 },
                    { new DateTime(2025, 1, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.030000000000001 },
                    { new DateTime(2025, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.479999999999997 },
                    { new DateTime(2025, 1, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.11000000000001 },
                    { new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.840000000000003 },
                    { new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.449999999999999 },
                    { new DateTime(2025, 1, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 86.299999999999997 },
                    { new DateTime(2025, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.990000000000002 },
                    { new DateTime(2025, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.109999999999999 },
                    { new DateTime(2025, 1, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.289999999999999 },
                    { new DateTime(2025, 1, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 124.65000000000001 },
                    { new DateTime(2025, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.560000000000002 },
                    { new DateTime(2025, 1, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.390000000000001 },
                    { new DateTime(2025, 1, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.659999999999997 },
                    { new DateTime(2025, 1, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.920000000000002 },
                    { new DateTime(2025, 1, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.16 },
                    { new DateTime(2025, 1, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.32 },
                    { new DateTime(2025, 1, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 75.5 },
                    { new DateTime(2025, 1, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 41.289999999999999 },
                    { new DateTime(2025, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.5 },
                    { new DateTime(2025, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 137.27000000000001 },
                    { new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.420000000000002 },
                    { new DateTime(2025, 1, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.019999999999996 },
                    { new DateTime(2025, 1, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.109999999999999 },
                    { new DateTime(2025, 1, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.579999999999998 },
                    { new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.869999999999997 },
                    { new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.869999999999997 },
                    { new DateTime(2025, 1, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.689999999999998 },
                    { new DateTime(2025, 1, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.09999999999999 },
                    { new DateTime(2025, 1, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.28 },
                    { new DateTime(2025, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.569999999999993 },
                    { new DateTime(2025, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.010000000000002 },
                    { new DateTime(2025, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 98.239999999999995 },
                    { new DateTime(2025, 1, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.939999999999998 },
                    { new DateTime(2025, 1, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.960000000000001 },
                    { new DateTime(2025, 1, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.079999999999998 },
                    { new DateTime(2025, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.090000000000003 },
                    { new DateTime(2025, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.289999999999999 },
                    { new DateTime(2025, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.859999999999999 },
                    { new DateTime(2025, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 96.5 },
                    { new DateTime(2025, 1, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.159999999999997 },
                    { new DateTime(2025, 1, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 113.67 },
                    { new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.620000000000005 },
                    { new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.69 },
                    { new DateTime(2025, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.189999999999998 },
                    { new DateTime(2025, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.549999999999997 },
                    { new DateTime(2025, 1, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.010000000000005 },
                    { new DateTime(2025, 1, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.460000000000001 },
                    { new DateTime(2025, 1, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.959999999999994 },
                    { new DateTime(2025, 1, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.56 },
                    { new DateTime(2025, 1, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.879999999999995 },
                    { new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.759999999999998 },
                    { new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 71.180000000000007 },
                    { new DateTime(2025, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.739999999999995 },
                    { new DateTime(2025, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 100.18000000000001 },
                    { new DateTime(2025, 1, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.850000000000001 },
                    { new DateTime(2025, 1, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.969999999999999 },
                    { new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.950000000000003 },
                    { new DateTime(2025, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 81.870000000000005 },
                    { new DateTime(2025, 1, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.310000000000002 },
                    { new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.329999999999998 },
                    { new DateTime(2025, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.530000000000001 },
                    { new DateTime(2025, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 71.930000000000007 },
                    { new DateTime(2025, 2, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.289999999999999 },
                    { new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.939999999999998 },
                    { new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.18 },
                    { new DateTime(2025, 2, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.420000000000002 },
                    { new DateTime(2025, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 117.76000000000001 },
                    { new DateTime(2025, 2, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.359999999999999 },
                    { new DateTime(2025, 2, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.549999999999997 },
                    { new DateTime(2025, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.399999999999999 },
                    { new DateTime(2025, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.439999999999998 },
                    { new DateTime(2025, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.609999999999999 },
                    { new DateTime(2025, 2, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.380000000000003 },
                    { new DateTime(2025, 2, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.390000000000001 },
                    { new DateTime(2025, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.049999999999997 },
                    { new DateTime(2025, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.07 },
                    { new DateTime(2025, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.829999999999998 },
                    { new DateTime(2025, 2, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.109999999999999 },
                    { new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.629999999999995 },
                    { new DateTime(2025, 2, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.989999999999995 },
                    { new DateTime(2025, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.030000000000001 },
                    { new DateTime(2025, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.379999999999999 },
                    { new DateTime(2025, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.290000000000006 },
                    { new DateTime(2025, 2, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.32 },
                    { new DateTime(2025, 2, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.18000000000001 },
                    { new DateTime(2025, 2, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.520000000000003 },
                    { new DateTime(2025, 2, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.86 },
                    { new DateTime(2025, 2, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.340000000000003 },
                    { new DateTime(2025, 2, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.17 },
                    { new DateTime(2025, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.459999999999994 },
                    { new DateTime(2025, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.189999999999998 },
                    { new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.519999999999996 },
                    { new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.64 },
                    { new DateTime(2025, 2, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.799999999999997 },
                    { new DateTime(2025, 2, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.43 },
                    { new DateTime(2025, 2, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.82 },
                    { new DateTime(2025, 2, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 73.280000000000001 },
                    { new DateTime(2025, 2, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.399999999999999 },
                    { new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.490000000000002 },
                    { new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 113.81 },
                    { new DateTime(2025, 2, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.649999999999999 },
                    { new DateTime(2025, 2, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.41 },
                    { new DateTime(2025, 2, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.299999999999997 },
                    { new DateTime(2025, 2, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 89.430000000000007 },
                    { new DateTime(2025, 2, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.829999999999998 },
                    { new DateTime(2025, 2, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 114.37 },
                    { new DateTime(2025, 2, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.27 },
                    { new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.209999999999994 },
                    { new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.380000000000003 },
                    { new DateTime(2025, 2, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.450000000000003 },
                    { new DateTime(2025, 2, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.829999999999998 },
                    { new DateTime(2025, 2, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 128.97999999999999 },
                    { new DateTime(2025, 2, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.960000000000001 },
                    { new DateTime(2025, 2, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.019999999999996 },
                    { new DateTime(2025, 2, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.959999999999994 },
                    { new DateTime(2025, 2, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.459999999999994 },
                    { new DateTime(2025, 2, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.51000000000001 },
                    { new DateTime(2025, 2, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.5 },
                    { new DateTime(2025, 2, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.550000000000001 },
                    { new DateTime(2025, 2, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.490000000000002 },
                    { new DateTime(2025, 2, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 82.379999999999995 },
                    { new DateTime(2025, 2, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 125.78 },
                    { new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.879999999999995 },
                    { new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.649999999999999 },
                    { new DateTime(2025, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 94.25 },
                    { new DateTime(2025, 2, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.349999999999994 },
                    { new DateTime(2025, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.049999999999997 },
                    { new DateTime(2025, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.729999999999997 },
                    { new DateTime(2025, 2, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 139.00999999999999 },
                    { new DateTime(2025, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 82.340000000000003 },
                    { new DateTime(2025, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.689999999999998 },
                    { new DateTime(2025, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 76.189999999999998 },
                    { new DateTime(2025, 2, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 129.99000000000001 },
                    { new DateTime(2025, 2, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.909999999999997 },
                    { new DateTime(2025, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.579999999999998 },
                    { new DateTime(2025, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.200000000000003 },
                    { new DateTime(2025, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.509999999999998 },
                    { new DateTime(2025, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.590000000000003 },
                    { new DateTime(2025, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 117.0 },
                    { new DateTime(2025, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.310000000000002 },
                    { new DateTime(2025, 2, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.090000000000003 },
                    { new DateTime(2025, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.450000000000003 },
                    { new DateTime(2025, 2, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.760000000000005 },
                    { new DateTime(2025, 2, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.90000000000001 },
                    { new DateTime(2025, 2, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.509999999999998 },
                    { new DateTime(2025, 2, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.969999999999999 },
                    { new DateTime(2025, 2, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.34999999999999 },
                    { new DateTime(2025, 2, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 93.939999999999998 },
                    { new DateTime(2025, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.920000000000002 },
                    { new DateTime(2025, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 138.18000000000001 },
                    { new DateTime(2025, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.019999999999996 },
                    { new DateTime(2025, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.050000000000001 },
                    { new DateTime(2025, 2, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.560000000000002 },
                    { new DateTime(2025, 2, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.66 },
                    { new DateTime(2025, 2, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 125.41 },
                    { new DateTime(2025, 2, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.280000000000001 },
                    { new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.619999999999997 },
                    { new DateTime(2025, 2, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.049999999999997 },
                    { new DateTime(2025, 2, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.5 },
                    { new DateTime(2025, 2, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.030000000000001 },
                    { new DateTime(2025, 2, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.980000000000004 },
                    { new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.960000000000001 },
                    { new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.579999999999998 },
                    { new DateTime(2025, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.140000000000001 },
                    { new DateTime(2025, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.02 },
                    { new DateTime(2025, 2, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.030000000000001 },
                    { new DateTime(2025, 2, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.030000000000001 },
                    { new DateTime(2025, 2, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.420000000000002 },
                    { new DateTime(2025, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.89 },
                    { new DateTime(2025, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 87.900000000000006 },
                    { new DateTime(2025, 2, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.890000000000001 },
                    { new DateTime(2025, 2, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 71.400000000000006 },
                    { new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 70.239999999999995 },
                    { new DateTime(2025, 2, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.270000000000003 },
                    { new DateTime(2025, 2, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.459999999999994 },
                    { new DateTime(2025, 2, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 50.75 },
                    { new DateTime(2025, 2, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 118.81999999999999 },
                    { new DateTime(2025, 2, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 55.920000000000002 },
                    { new DateTime(2025, 2, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.229999999999997 },
                    { new DateTime(2025, 2, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 90.829999999999998 },
                    { new DateTime(2025, 2, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.030000000000001 },
                    { new DateTime(2025, 2, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.260000000000005 },
                    { new DateTime(2025, 2, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.810000000000002 },
                    { new DateTime(2025, 2, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.880000000000003 },
                    { new DateTime(2025, 2, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.74000000000001 },
                    { new DateTime(2025, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.420000000000002 },
                    { new DateTime(2025, 2, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.490000000000002 },
                    { new DateTime(2025, 2, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 122.55 },
                    { new DateTime(2025, 2, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.3 },
                    { new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.689999999999998 },
                    { new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.430000000000007 },
                    { new DateTime(2025, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.670000000000002 },
                    { new DateTime(2025, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.049999999999997 },
                    { new DateTime(2025, 2, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 85.579999999999998 },
                    { new DateTime(2025, 2, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.309999999999999 },
                    { new DateTime(2025, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.509999999999998 },
                    { new DateTime(2025, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.01000000000001 },
                    { new DateTime(2025, 2, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 71.969999999999999 },
                    { new DateTime(2025, 2, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 96.420000000000002 },
                    { new DateTime(2025, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 56.119999999999997 },
                    { new DateTime(2025, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.369999999999997 },
                    { new DateTime(2025, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.280000000000001 },
                    { new DateTime(2025, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.43000000000001 },
                    { new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 63.939999999999998 },
                    { new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.07 },
                    { new DateTime(2025, 2, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.090000000000003 },
                    { new DateTime(2025, 2, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.549999999999997 },
                    { new DateTime(2025, 2, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.409999999999997 },
                    { new DateTime(2025, 2, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.84999999999999 },
                    { new DateTime(2025, 2, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 51.240000000000002 },
                    { new DateTime(2025, 2, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.049999999999997 },
                    { new DateTime(2025, 2, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.45999999999999 },
                    { new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.420000000000002 },
                    { new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.58000000000001 },
                    { new DateTime(2025, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.090000000000003 },
                    { new DateTime(2025, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.600000000000001 },
                    { new DateTime(2025, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 126.87 },
                    { new DateTime(2025, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.240000000000002 },
                    { new DateTime(2025, 2, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.390000000000001 },
                    { new DateTime(2025, 2, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.109999999999999 },
                    { new DateTime(2025, 2, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 89.769999999999996 },
                    { new DateTime(2025, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.68 },
                    { new DateTime(2025, 2, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 90.939999999999998 },
                    { new DateTime(2025, 2, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 137.50999999999999 },
                    { new DateTime(2025, 2, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.799999999999997 },
                    { new DateTime(2025, 2, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 98.459999999999994 },
                    { new DateTime(2025, 2, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.229999999999997 },
                    { new DateTime(2025, 2, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.600000000000001 },
                    { new DateTime(2025, 2, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.469999999999999 },
                    { new DateTime(2025, 2, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 55.829999999999998 },
                    { new DateTime(2025, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.369999999999997 },
                    { new DateTime(2025, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 78.769999999999996 },
                    { new DateTime(2025, 2, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 106.39 },
                    { new DateTime(2025, 2, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 113.14 },
                    { new DateTime(2025, 2, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 50.420000000000002 },
                    { new DateTime(2025, 2, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.97 },
                    { new DateTime(2025, 2, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.18 },
                    { new DateTime(2025, 2, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.5 },
                    { new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.959999999999994 },
                    { new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.78 },
                    { new DateTime(2025, 2, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.620000000000005 },
                    { new DateTime(2025, 2, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.579999999999998 },
                    { new DateTime(2025, 2, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 131.84 },
                    { new DateTime(2025, 2, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.350000000000001 },
                    { new DateTime(2025, 2, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.230000000000004 },
                    { new DateTime(2025, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.29000000000001 },
                    { new DateTime(2025, 2, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.649999999999999 },
                    { new DateTime(2025, 2, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.42 },
                    { new DateTime(2025, 2, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 68.920000000000002 },
                    { new DateTime(2025, 2, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.23 },
                    { new DateTime(2025, 2, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.340000000000003 },
                    { new DateTime(2025, 2, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.299999999999997 },
                    { new DateTime(2025, 2, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.219999999999999 },
                    { new DateTime(2025, 2, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 52.469999999999999 },
                    { new DateTime(2025, 2, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.219999999999999 },
                    { new DateTime(2025, 2, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 55.07 },
                    { new DateTime(2025, 2, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 121.16 },
                    { new DateTime(2025, 2, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.710000000000001 },
                    { new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.840000000000003 },
                    { new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.439999999999998 },
                    { new DateTime(2025, 2, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.07 },
                    { new DateTime(2025, 2, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.670000000000002 },
                    { new DateTime(2025, 2, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.390000000000001 },
                    { new DateTime(2025, 2, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 98.719999999999999 },
                    { new DateTime(2025, 2, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 58.439999999999998 },
                    { new DateTime(2025, 2, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.090000000000003 },
                    { new DateTime(2025, 2, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.149999999999999 },
                    { new DateTime(2025, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.450000000000003 },
                    { new DateTime(2025, 2, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.939999999999998 },
                    { new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.649999999999999 },
                    { new DateTime(2025, 2, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 126.48 },
                    { new DateTime(2025, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 96.730000000000004 },
                    { new DateTime(2025, 2, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.159999999999997 },
                    { new DateTime(2025, 2, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.659999999999997 },
                    { new DateTime(2025, 2, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.460000000000001 },
                    { new DateTime(2025, 2, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.49000000000001 },
                    { new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.969999999999999 },
                    { new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.760000000000005 },
                    { new DateTime(2025, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.480000000000004 },
                    { new DateTime(2025, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.060000000000002 },
                    { new DateTime(2025, 2, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 86.939999999999998 },
                    { new DateTime(2025, 2, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 136.88 },
                    { new DateTime(2025, 2, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.979999999999997 },
                    { new DateTime(2025, 2, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 132.84999999999999 },
                    { new DateTime(2025, 2, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.840000000000003 },
                    { new DateTime(2025, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.430000000000007 },
                    { new DateTime(2025, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.840000000000003 },
                    { new DateTime(2025, 2, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 85.75 },
                    { new DateTime(2025, 2, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.229999999999997 },
                    { new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 70.480000000000004 },
                    { new DateTime(2025, 2, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.890000000000001 },
                    { new DateTime(2025, 2, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.329999999999998 },
                    { new DateTime(2025, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 103.7 },
                    { new DateTime(2025, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.380000000000003 },
                    { new DateTime(2025, 2, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.490000000000002 },
                    { new DateTime(2025, 2, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.379999999999995 },
                    { new DateTime(2025, 2, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.329999999999998 },
                    { new DateTime(2025, 2, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.82 },
                    { new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 90.599999999999994 },
                    { new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.729999999999997 },
                    { new DateTime(2025, 2, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 134.09999999999999 },
                    { new DateTime(2025, 2, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 39.840000000000003 },
                    { new DateTime(2025, 2, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.93 },
                    { new DateTime(2025, 2, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.260000000000005 },
                    { new DateTime(2025, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.979999999999997 },
                    { new DateTime(2025, 2, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 66.299999999999997 },
                    { new DateTime(2025, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 91.680000000000007 },
                    { new DateTime(2025, 2, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.829999999999998 },
                    { new DateTime(2025, 2, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.269999999999996 },
                    { new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.019999999999996 },
                    { new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.259999999999998 },
                    { new DateTime(2025, 2, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.359999999999999 },
                    { new DateTime(2025, 2, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.12 },
                    { new DateTime(2025, 2, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.82 },
                    { new DateTime(2025, 2, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 107.11 },
                    { new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 60.920000000000002 },
                    { new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.840000000000003 },
                    { new DateTime(2025, 2, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.079999999999998 },
                    { new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 50.490000000000002 },
                    { new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.219999999999999 },
                    { new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.17 },
                    { new DateTime(2025, 2, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 56.969999999999999 },
                    { new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.849999999999994 },
                    { new DateTime(2025, 2, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 82.890000000000001 },
                    { new DateTime(2025, 2, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.240000000000002 },
                    { new DateTime(2025, 2, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 98.760000000000005 },
                    { new DateTime(2025, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.350000000000001 },
                    { new DateTime(2025, 2, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.299999999999997 },
                    { new DateTime(2025, 2, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 83.519999999999996 },
                    { new DateTime(2025, 2, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.920000000000002 },
                    { new DateTime(2025, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.030000000000001 },
                    { new DateTime(2025, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 135.66999999999999 },
                    { new DateTime(2025, 2, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.459999999999994 },
                    { new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.859999999999999 },
                    { new DateTime(2025, 2, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.600000000000001 },
                    { new DateTime(2025, 2, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 127.05 },
                    { new DateTime(2025, 2, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.539999999999999 },
                    { new DateTime(2025, 2, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.769999999999996 },
                    { new DateTime(2025, 2, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.530000000000001 },
                    { new DateTime(2025, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.739999999999995 },
                    { new DateTime(2025, 2, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 50.409999999999997 },
                    { new DateTime(2025, 2, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.039999999999999 },
                    { new DateTime(2025, 2, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.95999999999999 },
                    { new DateTime(2025, 2, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.420000000000002 },
                    { new DateTime(2025, 2, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.180000000000007 },
                    { new DateTime(2025, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 120.45999999999999 },
                    { new DateTime(2025, 2, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.409999999999997 },
                    { new DateTime(2025, 2, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.299999999999997 },
                    { new DateTime(2025, 2, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.469999999999999 },
                    { new DateTime(2025, 2, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.849999999999994 },
                    { new DateTime(2025, 2, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.0 },
                    { new DateTime(2025, 2, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 94.260000000000005 },
                    { new DateTime(2025, 2, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.579999999999998 },
                    { new DateTime(2025, 2, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 85.040000000000006 },
                    { new DateTime(2025, 2, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 119.59999999999999 },
                    { new DateTime(2025, 2, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 108.3 },
                    { new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.439999999999998 },
                    { new DateTime(2025, 2, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.270000000000003 },
                    { new DateTime(2025, 2, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.280000000000001 },
                    { new DateTime(2025, 2, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 74.140000000000001 },
                    { new DateTime(2025, 2, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.840000000000003 },
                    { new DateTime(2025, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.740000000000002 },
                    { new DateTime(2025, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.07 },
                    { new DateTime(2025, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 139.87 },
                    { new DateTime(2025, 2, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.07 },
                    { new DateTime(2025, 2, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.590000000000003 },
                    { new DateTime(2025, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.870000000000001 },
                    { new DateTime(2025, 2, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.859999999999999 },
                    { new DateTime(2025, 2, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 96.359999999999999 },
                    { new DateTime(2025, 2, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 86.459999999999994 },
                    { new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.289999999999999 },
                    { new DateTime(2025, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.530000000000001 },
                    { new DateTime(2025, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 84.920000000000002 },
                    { new DateTime(2025, 2, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 75.459999999999994 },
                    { new DateTime(2025, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 54.240000000000002 },
                    { new DateTime(2025, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.579999999999998 },
                    { new DateTime(2025, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 80.959999999999994 },
                    { new DateTime(2025, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.42 },
                    { new DateTime(2025, 2, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 59.049999999999997 },
                    { new DateTime(2025, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 67.230000000000004 },
                    { new DateTime(2025, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 74.370000000000005 },
                    { new DateTime(2025, 2, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 45.200000000000003 },
                    { new DateTime(2025, 2, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 54.600000000000001 },
                    { new DateTime(2025, 2, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 82.390000000000001 },
                    { new DateTime(2025, 2, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.350000000000001 },
                    { new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 47.82 },
                    { new DateTime(2025, 2, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.28 },
                    { new DateTime(2025, 2, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.68 },
                    { new DateTime(2025, 2, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.939999999999998 },
                    { new DateTime(2025, 2, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.25 },
                    { new DateTime(2025, 2, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.239999999999995 },
                    { new DateTime(2025, 2, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.149999999999999 },
                    { new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.930000000000007 },
                    { new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 36.200000000000003 },
                    { new DateTime(2025, 2, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.0 },
                    { new DateTime(2025, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 70.129999999999995 },
                    { new DateTime(2025, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.200000000000003 },
                    { new DateTime(2025, 2, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 34.100000000000001 },
                    { new DateTime(2025, 2, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.520000000000003 },
                    { new DateTime(2025, 2, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 103.02 },
                    { new DateTime(2025, 2, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 89.189999999999998 },
                    { new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 133.97 },
                    { new DateTime(2025, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 88.590000000000003 },
                    { new DateTime(2025, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 128.59999999999999 },
                    { new DateTime(2025, 2, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.520000000000003 },
                    { new DateTime(2025, 2, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.859999999999999 },
                    { new DateTime(2025, 2, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 132.88999999999999 },
                    { new DateTime(2025, 2, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 37.689999999999998 },
                    { new DateTime(2025, 2, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 116.56 },
                    { new DateTime(2025, 2, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.689999999999998 },
                    { new DateTime(2025, 2, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 105.36 },
                    { new DateTime(2025, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 83.579999999999998 },
                    { new DateTime(2025, 2, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 79.060000000000002 },
                    { new DateTime(2025, 2, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 38.609999999999999 },
                    { new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 93.370000000000005 },
                    { new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.640000000000001 },
                    { new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 87.049999999999997 },
                    { new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 41.149999999999999 },
                    { new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 73.280000000000001 },
                    { new DateTime(2025, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.140000000000001 },
                    { new DateTime(2025, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 90.730000000000004 },
                    { new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 65.180000000000007 },
                    { new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 82.799999999999997 },
                    { new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 31.719999999999999 },
                    { new DateTime(2025, 3, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.140000000000001 },
                    { new DateTime(2025, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 122.8 },
                    { new DateTime(2025, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 123.8 },
                    { new DateTime(2025, 3, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.090000000000003 },
                    { new DateTime(2025, 3, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 85.760000000000005 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2024, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 1, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL" });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "Date", "VenueCode" },
                keyValues: new object[] { new DateTime(2025, 3, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR" });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Date", "VenueCode", "CostPerHour" },
                values: new object[,]
                {
                    { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.789999999999999 },
                    { new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 46.770000000000003 },
                    { new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 72.069999999999993 },
                    { new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.030000000000001 },
                    { new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 57.18 },
                    { new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 61.130000000000003 },
                    { new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 139.55000000000001 },
                    { new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 96.379999999999995 },
                    { new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 92.689999999999998 },
                    { new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 95.010000000000005 },
                    { new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 59.859999999999999 },
                    { new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.450000000000003 },
                    { new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 55.439999999999998 },
                    { new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 79.260000000000005 },
                    { new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.489999999999995 },
                    { new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 97.650000000000006 },
                    { new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 57.399999999999999 },
                    { new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 58.020000000000003 },
                    { new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.489999999999995 },
                    { new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.630000000000003 },
                    { new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 94.670000000000002 },
                    { new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 32.43 },
                    { new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 68.049999999999997 },
                    { new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.519999999999996 },
                    { new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.119999999999997 },
                    { new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 49.280000000000001 },
                    { new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.76000000000001 },
                    { new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 30.91 },
                    { new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 99.439999999999998 },
                    { new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 69.359999999999999 },
                    { new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 76.140000000000001 },
                    { new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.019999999999996 },
                    { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.479999999999997 },
                    { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.88 },
                    { new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 109.15000000000001 },
                    { new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.89 },
                    { new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 64.030000000000001 },
                    { new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.840000000000003 },
                    { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 92.319999999999993 },
                    { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 40.109999999999999 },
                    { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 76.810000000000002 },
                    { new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.659999999999997 },
                    { new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 43.719999999999999 },
                    { new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 42.299999999999997 },
                    { new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 51.560000000000002 },
                    { new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 87.870000000000005 },
                    { new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 48.590000000000003 },
                    { new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 84.980000000000004 },
                    { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 80.769999999999996 },
                    { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.850000000000001 },
                    { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 83.709999999999994 },
                    { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 91.530000000000001 },
                    { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 132.13 },
                    { new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 104.41 },
                    { new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 114.65000000000001 },
                    { new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 50.390000000000001 },
                    { new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 95.829999999999998 },
                    { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 62.539999999999999 },
                    { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 78.430000000000007 },
                    { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 77.700000000000003 },
                    { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 33.030000000000001 },
                    { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 110.11 },
                    { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 77.640000000000001 },
                    { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 130.16999999999999 },
                    { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 35.670000000000002 },
                    { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 101.31999999999999 },
                    { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 53.219999999999999 },
                    { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 74.150000000000006 },
                    { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 102.22 },
                    { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 44.049999999999997 },
                    { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 99.879999999999995 },
                    { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 115.3 },
                    { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CRKHL", 72.340000000000003 },
                    { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 53.810000000000002 },
                    { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "FDLCK", 52.939999999999998 },
                    { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "TNDMR", 112.63 }
                });
        }
    }
}
