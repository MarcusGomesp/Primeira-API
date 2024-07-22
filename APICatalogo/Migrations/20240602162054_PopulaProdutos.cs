using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Coca-cola Diet', 'Refrigerante Cola 350 ml', '5.45', 'cocacola.jpg',50,GETDATE(),1)"); // ID 1 Bebidas

            mb.Sql("Insert Into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) "+ //ID 2 Lanches 
                "Values('Lanche de Atum','Lanche de Atum com maionese',8.50,'atum.jpg',10,GETDATE(),2)");

            mb.Sql("Insert Into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " + //ID 3 Sobremesas 
                "Values('Pudim 100g','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,GETDATE(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
