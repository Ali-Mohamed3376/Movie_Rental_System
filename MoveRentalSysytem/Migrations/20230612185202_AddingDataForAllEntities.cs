using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoveRentalSysytem.Migrations
{
    /// <inheritdoc />
    public partial class AddingDataForAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Sharqia", new DateTime(1999, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", "Moh.", 1123702048 },
                    { 2, "Cairo", new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reem", "Issam.", 1023521021 },
                    { 3, "Aswaan", new DateTime(1995, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adel", "Makram", 1023521021 },
                    { 4, "Helwan", new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed", "Helmy", 1023521021 },
                    { 5, "Daqhlia", new DateTime(2003, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sawsan", "Bader", 1254875212 }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "CompanyName", "Country" },
                values: new object[,]
                {
                    { 1, "Al Adel Group", "Syrya" },
                    { 2, "Synergy", "Egypt" },
                    { 3, "Al Zahraa", "Libya" },
                    { 4, "Maspiro", "Egypt" },
                    { 5, "Tamer Hosny Group", "Russia" },
                    { 6, "Ali Baba", "Egypt" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Duration", "Movie_Name", "ProducerId", "Rating" },
                values: new object[,]
                {
                    { 1, 2, "El Kaief", 1, 5 },
                    { 2, 1, "El Ghwass", 2, 7 },
                    { 3, 3, "KarKar", 2, 9 },
                    { 4, 2, "El Guass", 3, 10 },
                    { 5, 4, "El Hroup", 4, 3 },
                    { 6, 1, "Kalb Balady", 1, 8 },
                    { 7, 3, "El Qurmoty", 5, 6 },
                    { 8, 2, "Hanfy El Obha", 4, 5 },
                    { 9, 2, "Kabab Mashwy", 5, 7 },
                    { 10, 3, "Amir El Zalam", 6, 10 }
                });

            migrationBuilder.InsertData(
                table: "Customer_Movies",
                columns: new[] { "CustomerId", "MovieId", "Date_Rented", "Due_Date" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 10, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 10, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 5, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ProducerId",
                keyValue: 6);
        }
    }
}
