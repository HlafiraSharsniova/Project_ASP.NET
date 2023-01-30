using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class NameFixId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Reservations_Procedures_ProcedureID",
                table: "Procedures_Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Reservations_Reservations_ReservationID",
                table: "Procedures_Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "ReservationID",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "ProcedureCategory",
                table: "Reservations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReservationID",
                table: "Procedures_Reservations",
                newName: "ReservationId");

            migrationBuilder.RenameColumn(
                name: "ProcedureID",
                table: "Procedures_Reservations",
                newName: "ProcedureId");

            migrationBuilder.RenameIndex(
                name: "IX_Procedures_Reservations_ReservationID",
                table: "Procedures_Reservations",
                newName: "IX_Procedures_Reservations_ReservationId");

            migrationBuilder.RenameColumn(
                name: "ProcedureId",
                table: "Procedures",
                newName: "ProcedureCategory");

            migrationBuilder.RenameColumn(
                name: "MasterID",
                table: "Masters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Clients",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Procedures",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureCategory",
                table: "Procedures",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Procedures",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Reservations_Procedures_ProcedureId",
                table: "Procedures_Reservations",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Reservations_Reservations_ReservationId",
                table: "Procedures_Reservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Reservations_Procedures_ProcedureId",
                table: "Procedures_Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Reservations_Reservations_ReservationId",
                table: "Procedures_Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Procedures");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reservations",
                newName: "ProcedureCategory");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Procedures_Reservations",
                newName: "ReservationID");

            migrationBuilder.RenameColumn(
                name: "ProcedureId",
                table: "Procedures_Reservations",
                newName: "ProcedureID");

            migrationBuilder.RenameIndex(
                name: "IX_Procedures_Reservations_ReservationId",
                table: "Procedures_Reservations",
                newName: "IX_Procedures_Reservations_ReservationID");

            migrationBuilder.RenameColumn(
                name: "ProcedureCategory",
                table: "Procedures",
                newName: "ProcedureId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Masters",
                newName: "MasterID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ClientID");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureCategory",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ReservationID",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Procedures",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "Procedures",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures",
                column: "ProcedureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Reservations_Procedures_ProcedureID",
                table: "Procedures_Reservations",
                column: "ProcedureID",
                principalTable: "Procedures",
                principalColumn: "ProcedureId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Reservations_Reservations_ReservationID",
                table: "Procedures_Reservations",
                column: "ReservationID",
                principalTable: "Reservations",
                principalColumn: "ReservationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
