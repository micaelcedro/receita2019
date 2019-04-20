using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas2019.Web.Migrations
{
    public partial class updatereceitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Receitas");
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem, categoriaId) VALUES ('Bolo de Fuba', 'Em um liquidificador, adicione os ovos, o açúcar, o fubá, a farinha de trigo, o óleo, o leite e o fermento, depois bata até a massa ficar lisa e homogênea. Despeje a massa em uma forma untada e polvilhada. Leve para assar em forno médio 180 °C) preaquecido por 40 minutos.', 40,'https://img.itdg.com.br/tdg/images/recipes/000/009/254/10495/10495_original.jpg?mode=crop&width=710&height=400', 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem, categoriaId) VALUES ('Brigadeiro', 'Em uma panela funda, acrescente o leite condensado, a margarina e o chocolate em pó. Cozinhe em fogo médio e mexa até que o brigadeiro comece a desgrudar da panela. Deixe esfriar e faça pequenas bolas com a mão passando a massa no chocolate granulado.', 25,'https://img.itdg.com.br/tdg/images/recipes/000/000/114/75811/75811_original.jpg?mode=crop&width=710&height=400', 1)");
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem, categoriaId) VALUES ('Torta de Sardinha', 'Misture todos os ingredientes do recheio. Em uma assadeira untada e enfarinhada, coloque metade da massa, depois todo o recheio e por fim o restante da massa. Leve ao forno pré - aquecido, à 180º, por 40 a 50 minutos. Sirva quente.', 60,'https://img.itdg.com.br/tdg/images/recipes/000/037/088/3243/3243_original.jpg?mode=crop&width=710&height=400', 2)");
            migrationBuilder.Sql("INSERT INTO Receitas(Nome, ModoDePreparo, TempoDePreparo, Imagem, categoriaId) VALUES ('Bolo de Carne', 'Tempere a carne moída com a sopa de cebola, o tempero verde e o sal.Coloque a carne temperada sobre uma folha de papel laminado ou papel manteiga e abra a massa com um rolo, na espessura de 1 cm, mais ou menos.Forre a carne com o presunto e o queijo, pode-se colocar também milho verde, ervilha e requeijão. Enrole a carne, com ajuda da folha de papel laminado ou manteiga, em forma de rocambole. Leve ao forno, em temperatura alta, por mais ou menos 30 minutos, ou no microondas por 15 minutos. Bom apetite!', 15,'https://img.itdg.com.br/tdg/images/recipes/000/001/598/298322/298322_original.jpg?mode=crop&width=710&height=400', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Receitas");
        }
    }
}
