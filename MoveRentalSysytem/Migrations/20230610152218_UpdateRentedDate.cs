using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoveRentalSysytem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRentedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 2, 2 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 2, 9 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 3, 3 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 7 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 8 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 5, 5 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 2, 2 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 2, 9 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 3, 3 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 7 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 8 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 5, 5 },
                column: "Date_Rented",
                value: new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
