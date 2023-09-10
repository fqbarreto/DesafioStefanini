using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produto(NomeProduto, Valor) VALUES('Desodorante', 10.99)");
            migrationBuilder.Sql("INSERT INTO Produto(NomeProduto, Valor) VALUES('Refrigerante', 5.49)");
            migrationBuilder.Sql("INSERT INTO Produto(NomeProduto, Valor) VALUES('Chips', 3.30)");
            migrationBuilder.Sql("INSERT INTO Produto(NomeProduto, Valor) VALUES('Sabonete', 15.99)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produto");
        }
    }
}
