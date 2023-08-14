using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Treinar.Migrations
{
    /// <inheritdoc />
    public partial class cep_clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Idade",
                table: "ClienteModels",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "CepClienteId",
                table: "ClienteModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CepCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CepCliente", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteModels_CepClienteId",
                table: "ClienteModels",
                column: "CepClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteModels_CepCliente_CepClienteId",
                table: "ClienteModels",
                column: "CepClienteId",
                principalTable: "CepCliente",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteModels_CepCliente_CepClienteId",
                table: "ClienteModels");

            migrationBuilder.DropTable(
                name: "CepCliente");

            migrationBuilder.DropIndex(
                name: "IX_ClienteModels_CepClienteId",
                table: "ClienteModels");

            migrationBuilder.DropColumn(
                name: "CepClienteId",
                table: "ClienteModels");
        }
    }
}
