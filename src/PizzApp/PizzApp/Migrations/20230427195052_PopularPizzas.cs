using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzApp.Migrations
{
    public partial class PopularPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pizzas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsPizzaPreferida,PizzaName,Preco) " +
                "VALUES(1,'Molho de tomate artesanal, calabresa, cebola, queijo muçarela','Pizza feita de massa artesanal e preparada no " +
                "fogão à lenha',10,'~/imagens/pizzacalabresa.jpg','~/imagens/pizzacalabresa.jpg',1,'Pizza de Calabresa',60.00)");

            migrationBuilder.Sql("INSERT INTO Pizzas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsPizzaPreferida,PizzaName,Preco) " +
                "VALUES(1,'Molho de tomate artesanal, queijo muçarela, queijo parmessão, queijo gorgonzola, queijo provolone','Pizza feita " +
                "de massa artesanal e preparada no fogão à lenha',10,'https://ibb.co/02PchHf','https://ibb.co/02PchHf',0,'Pizza de 4 Queijos',64.00)");

            migrationBuilder.Sql("INSERT INTO Pizzas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsPizzaPreferida,PizzaName,Preco) " +
                "VALUES(1,'Molho de tomate artesanal, abobrinha, cebola, queijo muçarela, azeitona','Pizza feita de massa integral artesanal e " +
                "preparada no fogão à lenha',10,'~/imagens/pizzadeabobrinha.jpg','~/imagens/pizzadeabobrinha.jpg',0,'Pizza de Abobrinha',68.00)");

            migrationBuilder.Sql("INSERT INTO Pizzas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsPizzaPreferida,PizzaName,Preco) " +
                "VALUES(1,'Molho de tomate artesanal, cebola, queijo muçarela','Pizza feita de massa artesanal e preparada no fogão à " +
                "lenha',10,'~/imagens/pizzamarguerita.jpg','~/imagens/pizzamarguerita.jpg',0,'Pizza de Marguerita',60.00)");

            migrationBuilder.Sql("INSERT INTO Pizzas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsPizzaPreferida,PizzaName,Preco) " +
                "VALUES(2,'Brigadeiro gourmet, queijo muçarela, granulados','Pizza feita de massa artesanal e preparada no fogão à " +
                "lenha',10,'~/imagens/pizzabrigadeiro.png','~/imagens/pizzabrigadeiro.png',1,'Pizza de Brigadeiro',60.00)");

            migrationBuilder.Sql("INSERT INTO Pizzas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsPizzaPreferida,PizzaName,Preco) " +
                "VALUES(2,'Brigadeiro gourmet, queijo muçarela, morangos','Pizza feita de massa artesanal e preparada no fogão à " +
                "lenha',10,'~/imagens/pizzasensacao.jpg','~/imagens/pizzasensacao.jpg',0,'Pizza de Sensação',65.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Pizzas");
        }
    }
}
