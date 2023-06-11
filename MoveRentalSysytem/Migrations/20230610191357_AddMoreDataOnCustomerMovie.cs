using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoveRentalSysytem.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreDataOnCustomerMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer_Movies",
                columns: new[] { "CustomerId", "MovieId", "Date_Rented", "Due_Date" },
                values: new object[,]
                {
                    { 3, 10, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 5, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Customer_Movies",
                keyColumns: new[] { "CustomerId", "MovieId" },
                keyValues: new object[] { 4, 5 });
        }
    }
}
