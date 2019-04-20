using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas2019.Web.Migrations
{
    public partial class popularreceitas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem) VALUES ('Bolo de Fuba', 'Em um liquidificador, adicione os ovos, o açúcar, o fubá, a farinha de trigo, o óleo, o leite e o fermento, depois bata até a massa ficar lisa e homogênea. Despeje a massa em uma forma untada e polvilhada. Leve para assar em forno médio 180 °C) preaquecido por 40 minutos.', 30,'https://img.itdg.com.br/tdg/images/recipes/000/009/254/10495/10495_original.jpg?mode=crop&width=710&height=400')");
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem) VALUES ('Bolo de Fuba', 'Em um liquidificador, adicione os ovos, o açúcar, o fubá, a farinha de trigo, o óleo, o leite e o fermento, depois bata até a massa ficar lisa e homogênea. Despeje a massa em uma forma untada e polvilhada. Leve para assar em forno médio 180 °C) preaquecido por 40 minutos.', 40,'https://img.itdg.com.br/tdg/images/recipes/000/009/254/10495/10495_original.jpg?mode=crop&width=710&height=400')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Receitas");
        }
    }
}
