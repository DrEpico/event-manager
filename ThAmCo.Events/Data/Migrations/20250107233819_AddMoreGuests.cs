using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Events.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreGuests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "VenueReference",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                column: "Phone",
                value: "07412345678");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2,
                column: "Phone",
                value: "07323456789");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3,
                column: "Phone",
                value: "07734567890");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 4,
                column: "Phone",
                value: "07845678901");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 5,
                column: "Phone",
                value: "07956789012");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 6,
                column: "Phone",
                value: "07467890123");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 7,
                column: "Phone",
                value: "07378901234");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 8,
                column: "Phone",
                value: "07789012345");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 9,
                column: "Phone",
                value: "07890123456");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 10,
                column: "Phone",
                value: "07901234567");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 11,
                column: "Phone",
                value: "07411223344");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 12,
                column: "Phone",
                value: "07322334455");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 13,
                column: "Phone",
                value: "07733445566");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 14,
                column: "Phone",
                value: "07844556677");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 15,
                column: "Phone",
                value: "07955667788");

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "GuestId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 16, "paul.walker@example.com", "Paul Walker", "07466778899" },
                    { 17, "quincy.adams@example.com", "Quincy Adams", "07377889900" },
                    { 18, "rachel.scott@example.com", "Rachel Scott", "07788990011" },
                    { 19, "samuel.jackson@example.com", "Samuel Jackson", "07899001122" },
                    { 20, "tina.turner@example.com", "Tina Turner", "07900112233" },
                    { 21, "ulysses.grant@example.com", "Ulysses Grant", "07411223344" },
                    { 22, "victor.hugo@example.com", "Victor Hugo", "07322334455" },
                    { 23, "wendy.darling@example.com", "Wendy Darling", "07733445566" },
                    { 24, "xander.cage@example.com", "Xander Cage", "07844556677" },
                    { 25, "yasmine.lopez@example.com", "Yasmine Lopez", "07955667788" },
                    { 26, "zack.morris@example.com", "Zack Morris", "07466778899" },
                    { 27, "aaron.paul@example.com", "Aaron Paul", "07377889900" },
                    { 28, "beatrice.potter@example.com", "Beatrice Potter", "07788990011" },
                    { 29, "catherine.zeta@example.com", "Catherine Zeta", "07899001122" },
                    { 30, "david.beckham@example.com", "David Beckham", "07900112233" },
                    { 31, "elaine.benes@example.com", "Elaine Benes", "07411223344" },
                    { 32, "freddie.mercury@example.com", "Freddie Mercury", "07322334455" },
                    { 33, "george.clooney@example.com", "George Clooney", "07733445566" },
                    { 34, "helen.mirren@example.com", "Helen Mirren", "07844556677" },
                    { 35, "ian.mckellen@example.com", "Ian McKellen", "07955667788" },
                    { 36, "jessica.alba@example.com", "Jessica Alba", "07466778899" },
                    { 37, "kevin.hart@example.com", "Kevin Hart", "07377889900" },
                    { 38, "lana.del.rey@example.com", "Lana Del Rey", "07788990011" },
                    { 39, "michael.jordan@example.com", "Michael Jordan", "07899001122" },
                    { 40, "nancy.drew@example.com", "Nancy Drew", "07900112233" },
                    { 41, "oscar.wilde@example.com", "Oscar Wilde", "07411223344" },
                    { 42, "penelope.cruz@example.com", "Penelope Cruz", "07322334455" },
                    { 43, "quentin.tarantino@example.com", "Quentin Tarantino", "07733445566" },
                    { 44, "ryan.gosling@example.com", "Ryan Gosling", "07844556677" },
                    { 45, "scarlett.johansson@example.com", "Scarlett Johansson", "07955667788" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 45);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                column: "VenueReference",
                value: null);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1,
                column: "Phone",
                value: "1234567890");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2,
                column: "Phone",
                value: "2345678901");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3,
                column: "Phone",
                value: "3456789012");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 4,
                column: "Phone",
                value: "4567890123");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 5,
                column: "Phone",
                value: "5678901234");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 6,
                column: "Phone",
                value: "6789012345");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 7,
                column: "Phone",
                value: "7890123456");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 8,
                column: "Phone",
                value: "8901234567");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 9,
                column: "Phone",
                value: "9012345678");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 10,
                column: "Phone",
                value: "0123456789");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 11,
                column: "Phone",
                value: "1122334455");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 12,
                column: "Phone",
                value: "2233445566");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 13,
                column: "Phone",
                value: "3344556677");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 14,
                column: "Phone",
                value: "4455667788");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 15,
                column: "Phone",
                value: "5566778899");
        }
    }
}
