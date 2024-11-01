using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Catering.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodBookings",
                columns: table => new
                {
                    FoodBookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientReferenceId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "INTEGER", nullable: false),
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBookings", x => x.FoodBookingId);
                });

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    UnitPrice = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.FoodItemId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MenuName = table.Column<string>(type: "TEXT", nullable: false),
                    FoodBookingId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_FoodBookings_FoodBookingId",
                        column: x => x.FoodBookingId,
                        principalTable: "FoodBookings",
                        principalColumn: "FoodBookingId");
                });

            migrationBuilder.CreateTable(
                name: "MenuFoodItems",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodItemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuFoodItems", x => new { x.MenuId, x.FoodItemId });
                    table.ForeignKey(
                        name: "FK_MenuFoodItems_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "FoodItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuFoodItems_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FoodBookings",
                columns: new[] { "FoodBookingId", "ClientReferenceId", "MenuId", "NumberOfGuests" },
                values: new object[,]
                {
                    { 1, 1001, 1, 50 },
                    { 2, 1002, 2, 30 },
                    { 3, 1003, 3, 75 },
                    { 4, 1004, 4, 20 },
                    { 5, 1005, 5, 100 },
                    { 6, 1006, 6, 40 },
                    { 7, 1007, 7, 60 },
                    { 8, 1008, 8, 35 },
                    { 9, 1009, 9, 45 },
                    { 10, 1010, 10, 25 }
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Description", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Grilled Chicken", 12.5f },
                    { 2, "Vegan Salad", 8f },
                    { 3, "Chocolate Cake", 5f },
                    { 4, "Fruit Salad", 4.5f },
                    { 5, "Fish and Chips", 10f },
                    { 6, "Macaroni and Cheese", 6.5f },
                    { 7, "Caesar Salad", 7f },
                    { 8, "Pasta Primavera", 9f },
                    { 9, "Ice Cream Sundae", 3.5f },
                    { 10, "Pancakes", 4f }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "FoodBookingId", "MenuName" },
                values: new object[,]
                {
                    { 1, null, "Classic Menu" },
                    { 2, null, "Vegetarian Menu" },
                    { 3, null, "Vegan Menu" },
                    { 4, null, "Kids Menu" },
                    { 5, null, "Seafood Menu" },
                    { 6, null, "Italian Menu" },
                    { 7, null, "BBQ Menu" },
                    { 8, null, "Dessert Menu" },
                    { 9, null, "Breakfast Menu" },
                    { 10, null, "Lunch Menu" }
                });

            migrationBuilder.InsertData(
                table: "MenuFoodItems",
                columns: new[] { "FoodItemId", "MenuId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 5, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 2, 3 },
                    { 7, 3 },
                    { 6, 4 },
                    { 9, 4 },
                    { 5, 5 },
                    { 8, 5 },
                    { 7, 6 },
                    { 8, 6 },
                    { 1, 7 },
                    { 5, 7 },
                    { 3, 8 },
                    { 9, 8 },
                    { 4, 9 },
                    { 10, 9 },
                    { 6, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuFoodItems_FoodItemId",
                table: "MenuFoodItems",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_FoodBookingId",
                table: "Menus",
                column: "FoodBookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuFoodItems");

            migrationBuilder.DropTable(
                name: "FoodItems");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "FoodBookings");
        }
    }
}
