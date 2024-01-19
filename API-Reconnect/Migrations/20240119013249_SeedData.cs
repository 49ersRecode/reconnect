using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Reconnect.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FaleConosco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaleConosco", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Profissao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DatNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contatos_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Concluido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ServicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratos_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "FaleConosco",
                columns: new[] { "Id", "Email", "Mensagem", "Nome", "Status" },
                values: new object[,]
                {
                    { 1, "moraes@com", "Gostei muito do sistema, mas gostaria de trocar minha senha.", "Moraes", false },
                    { 2, "antoinho@com", "Como faço para me cadastrar sem ter um telefone?", "Antony Stark", false },
                    { 3, "nando@com", "Gostaria de saber como cadasro meu serviço.", "Fernanda Kipper", false }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Cpf", "DatNascimento", "Email", "Endereco", "Nome", "Profissao", "Senha", "Telefone" },
                values: new object[,]
                {
                    { 1, "123.456.789-98", new DateTime(1985, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "irineu@com", "Rua do gatos, n. 0", "Irineu Júnior", "Pedreiro", "123", "(12)98734-5678" },
                    { 2, "123.874.965-98", new DateTime(1965, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "carol@com", "Rua do viajantes, n. 10", "Carol Danvers", "Motorista", "123", "(97)98754-9548" },
                    { 3, "987.874.965-98", new DateTime(1942, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve@com", "Rua do caps, n. 450", "Steve Rogers", "Professor", "123", "(97)97541-6532" }
                });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "Id", "Descricao", "Nome", "UsuarioId" },
                values: new object[] { 1, "Serviços de professores", "Ensino", 3 });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "Id", "Descricao", "Nome", "UsuarioId" },
                values: new object[] { 2, "Reformas de todos os tipos", "Construção", 1 });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "Id", "Descricao", "Nome", "UsuarioId" },
                values: new object[] { 3, "Motorista de aplicativo", "Motorista", 3 });

            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Id", "Email", "Mensagem", "Nome", "ServicoId" },
                values: new object[,]
                {
                    { 1, "lukasich@com", "Gostaria de saber quanto custa ir para Fortaleza de carro!", "Lucas Chaves", 3 },
                    { 2, "juca@com", "Quanto custo reformar meu quarto?", "Juca Paz", 2 },
                    { 3, "anto@com", "Você ensina à domicílio?", "Antônio Freitas", 1 }
                });

            migrationBuilder.InsertData(
                table: "Contratos",
                columns: new[] { "Id", "Concluido", "DataHora", "Endereco", "ServicoId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 2, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "Rua do chinelo, 20", 2, 2 },
                    { 2, false, new DateTime(2024, 2, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), "Rua do Ensino Fundamental, 50", 1, 3 },
                    { 3, false, new DateTime(2024, 3, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Avenida Perdida, 120", 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_ServicoId",
                table: "Contatos",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_ServicoId",
                table: "Contratos",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_UsuarioId",
                table: "Contratos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_UsuarioId",
                table: "Servicos",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "FaleConosco");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
