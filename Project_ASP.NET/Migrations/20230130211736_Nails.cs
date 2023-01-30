using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class Nails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    MasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.MasterId);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfReservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionOfReservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgOfReservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priceOfReservation = table.Column<double>(type: "float", nullable: false),
                    DateOfReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcedureCategory = table.Column<int>(type: "int", nullable: false),
                    MasterID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Masters_MasterID",
                        column: x => x.MasterID,
                        principalTable: "Masters",
                        principalColumn: "MasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procedures_Reservations",
                columns: table => new
                {
                    ProcedureID = table.Column<int>(type: "int", nullable: false),
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures_Reservations", x => new { x.ProcedureID, x.ReservationID });
                    table.ForeignKey(
                        name: "FK_Procedures_Reservations_Procedures_ProcedureID",
                        column: x => x.ProcedureID,
                        principalTable: "Procedures",
                        principalColumn: "ProcedureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Procedures_Reservations_Reservations_ReservationID",
                        column: x => x.ReservationID,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_Reservations_ReservationID",
                table: "Procedures_Reservations",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ClientID",
                table: "Reservations",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MasterID",
                table: "Reservations",
                column: "MasterID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Procedures_Reservations");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Masters");
        }
    }
}
