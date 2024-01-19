using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Reconnect.Data
{
    public class SeedDataConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasData(
                new Usuario { Id= 1, Nome= "Irineu Júnior", Email= "irineu@com", Senha= "123", Telefone="(12)98734-5678", Profissao="Pedreiro", Cpf="123.456.789-98", Endereco= "Rua do gatos, n. 0", DatNascimento= DateTime.Parse("1985-03-13") },
                new Usuario { Id = 2, Nome = "Carol Danvers", Email = "carol@com", Senha = "123", Telefone = "(97)98754-9548", Profissao = "Motorista", Cpf = "123.874.965-98", Endereco = "Rua do viajantes, n. 10", DatNascimento = DateTime.Parse("1965-08-20") },
                new Usuario { Id = 3, Nome = "Steve Rogers", Email = "steve@com", Senha = "123", Telefone = "(97)97541-6532", Profissao = "Professor", Cpf = "987.874.965-98", Endereco = "Rua do caps, n. 450", DatNascimento = DateTime.Parse("1942-07-25") }

            );
        }
    }
}
