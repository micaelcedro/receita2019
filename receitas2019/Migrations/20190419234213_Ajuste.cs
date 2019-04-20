using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas2019.Web.Migrations
{
    public partial class Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Receitas");

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Receitas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Receitas");

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Receitas",
                nullable: true);
        }
    }
}
