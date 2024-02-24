using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasHackathon.Migrations
{
    public partial class atributo_cliente_ativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ativo_cliente",
                table: "tb_clientes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo_cliente",
                table: "tb_clientes");
        }
    }
}
