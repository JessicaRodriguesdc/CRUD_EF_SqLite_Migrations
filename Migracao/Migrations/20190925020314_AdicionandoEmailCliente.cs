using Microsoft.EntityFrameworkCore.Migrations;

namespace Migracao.Migrations
{
    public partial class AdicionandoEmailCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Clientes");
        }
    }
}
