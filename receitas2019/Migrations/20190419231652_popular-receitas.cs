using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas2019.Web.Migrations
{
    public partial class popularreceitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem) VALUES ('Torta de Sardinha', 'Misture todos os ingredientes do recheio. Em uma assadeira untada e enfarinhada, coloque metade da massa, depois todo o recheio e por fim o restante da massa. Leve ao forno pré - aquecido, à 180º, por 40 a 50 minutos. Sirva quente.', 60,'https://img.itdg.com.br/tdg/images/recipes/000/037/088/3243/3243_original.jpg?mode=crop&width=710&height=400', 2)");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Receitas");
        }
    }
}
