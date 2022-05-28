using Microsoft.EntityFrameworkCore.Migrations;

namespace projetoMVC.Data.Migrations
{
    public partial class CriaraTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Loja",
                columns: table => new
                {
                    IdLoja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLoja = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Loja", x => x.IdLoja);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Loja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Loja_Id_Loja",
                        column: x => x.Id_Loja,
                        principalTable: "tb_Loja",
                        principalColumn: "IdLoja",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_tb_Produto_tb_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Id_Produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "tb_Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_Id_Loja",
                table: "tb_Cliente",
                column: "Id_Loja");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Produto",
                table: "tb_Pagamento",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Produto_Id_Cliente",
                table: "tb_Produto",
                column: "Id_Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Produto");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Loja");
        }
    }
}
