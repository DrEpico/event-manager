using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThAmCo.Catering.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_FoodBookings_FoodBookingId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_FoodBookingId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "FoodBookingId",
                table: "Menus");

            migrationBuilder.CreateIndex(
                name: "IX_FoodBookings_MenuId",
                table: "FoodBookings",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodBookings_Menus_MenuId",
                table: "FoodBookings",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodBookings_Menus_MenuId",
                table: "FoodBookings");

            migrationBuilder.DropIndex(
                name: "IX_FoodBookings_MenuId",
                table: "FoodBookings");

            migrationBuilder.AddColumn<int>(
                name: "FoodBookingId",
                table: "Menus",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "FoodBookingId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_FoodBookingId",
                table: "Menus",
                column: "FoodBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_FoodBookings_FoodBookingId",
                table: "Menus",
                column: "FoodBookingId",
                principalTable: "FoodBookings",
                principalColumn: "FoodBookingId");
        }
    }
}
