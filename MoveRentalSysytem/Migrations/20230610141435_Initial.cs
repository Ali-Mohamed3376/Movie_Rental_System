using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoveRentalSysytem.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Country = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Movie_Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Duration = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Rating = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "ProducerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Movies",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Date_Rented = table.Column<DateTime>(type: "datetime", nullable: false),
                    Due_Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Movies", x => new { x.CustomerId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_Customer_Movies_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Movies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Movies_MovieId",
                table: "Customer_Movies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Movies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
