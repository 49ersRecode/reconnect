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
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "longtext", nullable: true)
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
                columns: new[] { "Id", "Bio", "Cpf", "DatNascimento", "Email", "Endereco", "Foto", "Nome", "Profissao", "Senha", "Telefone" },
                values: new object[,]
                {
                    { 1, "Faço transporte particular para eventos, viagens e empresas.", "123.456.789-98", new DateTime(1985, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "irineu@com", "Rua do Gatos, n. 0", "https://media.licdn.com/dms/image/C4D03AQH5__8lovq3Qw/profile-displayphoto-shrink_800_800/0/1521630576802?e=2147483647&v=beta&t=Sl_AZe5Cy1MvCT5yEKQcqpyDOHDPpvl8WiSDEj-YE0k", "Irineu Júnior", "Motorista", "123", "(12)98734-5678" },
                    { 2, "Ensino Matemática e Física para crianças, jovens e adultos.", "123.874.965-35", new DateTime(1965, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "carol@com", "Av. dos Viajantes, n. 1010", "https://i.pinimg.com/236x/a5/80/da/a580daf4f797e10a4e5443915bedba86.jpg", "Carol Danvers", "Professor(a)", "123", "(97)98754-9548" },
                    { 3, "Faço sua casa virar um paraíso!", "987.874.965-12", new DateTime(1942, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve@com", "Av. Capitão América, n. 450", "https://i.pinimg.com/originals/36/01/b3/3601b349f9f4b95528d7a85104c5ff15.jpg", "Steve Rogers", "Pedreiro", "123", "(97)97541-6532" },
                    { 4, "Limpo de tudo. Agenda livre para fins de semana!", "123.654.964-75", new DateTime(1983, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "marinete@com", "Rua Clean, n. 200", "https://www.estrelando.com.br/uploads/2016/09/08/7-1473346686.gallery.jpg", "Marinete D.", "Diarista", "123", "(11)985791-6965" },
                    { 5, "Sou profissional de motos, mais de 20 anos de experiência.", "987.345.965-98", new DateTime(1980, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jax@com", "Av. Charming, n. 120", "https://i.pinimg.com/736x/64/da/ab/64daab7bb0a107904f21831a0a7a9483.jpg", "Jax Teller", "Mecânico", "123", "(14)98751-6428" },
                    { 6, "Melhor encanador do bairro! Aceito todo tipo de trabalho.", "987.874.978-01", new DateTime(1990, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "mario@com", "Rua dos Canos, n. 450", "https://image-cdn.essentiallysports.com/wp-content/uploads/Mario-The-last-of-us-180x180.jpg", "Mário B.", "Encanador", "123", "(44)97515-6532" },
                    { 7, "Personal trainer para emagrecimento e definição.", "875.874.568-02", new DateTime(1981, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "natasha@com", "Av. Rua dos Exercícios, n. 85", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkNfq2S8h30n1dyTHFT4b1WfK41cB7lzFdyEuSPRz2W-vA94FEH9urevekbXg5EFbXQQ8&usqp=CAU", "Natasha  R.", "Personal Trainer", "123", "(97)97854-6578" },
                    { 8, "Cozinho com amor! Aceito encomendas, ganha brinde.", "986.742.123-03", new DateTime(2010, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "patsferrer@com", "Av. Panqueca, 7845", "https://patsferrer.github.io/49ers/src/images/perfis/perfil09.png", "Patricia F.", "Marmiteira", "123", "(85)89547-5478" }
                });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "Id", "Descricao", "Nome", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Serviços de professores", "Ensino", 2 },
                    { 2, "Motorista de aplicativo", "Motorista", 1 },
                    { 3, "Reformas de todos os tipos", "Reforma", 3 },
                    { 4, "Serviços de limpeza", "Serviços Domésticos", 4 },
                    { 5, "Reparo de automóveis", "Mecânico", 5 },
                    { 6, "Serviços de encanador", "Encanador", 6 },
                    { 7, "Serviços de Pesonal Trainer", "Personal", 7 },
                    { 8, "Serviços de cozinha", "Cozinha", 8 }
                });

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
