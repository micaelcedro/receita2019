using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas2019.Web.Migrations
{
    public partial class popularingredientes1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome) VALUES ('Ovo')");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome) VALUES ('Farinha de Trigo')");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome) VALUES ('Manteiga')");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome) VALUES ('Sal')");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome) VALUES ('Oleo')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Ingredientes");
        }
    }
}
