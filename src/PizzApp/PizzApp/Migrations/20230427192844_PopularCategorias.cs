using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzApp.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName, Descricao) " +
                "VALUES('Salgada', 'Pizza salgada feita com ingredientes de excelente qualidade')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName, Descricao) " +
                "VALUES('Doce', 'Pizza doce feita com o melhor chocolate')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
