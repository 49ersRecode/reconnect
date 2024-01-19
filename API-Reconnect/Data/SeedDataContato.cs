using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Reconnect.Data
{
    public class SeedDataContato : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasData(
                new Contato { Id = 1, Nome = "Lucas Chaves", Email = "lukasich@com", Mensagem = "Gostaria de saber quanto custa ir para Fortaleza de carro!", ServicoId=3 },
                new Contato { Id = 2, Nome = "Juca Paz", Email = "juca@com", Mensagem = "Quanto custo reformar meu quarto?", ServicoId = 2 },
                new Contato { Id = 3, Nome = "Antônio Freitas", Email = "anto@com", Mensagem = "Você ensina à domicílio?", ServicoId = 1 }
            );
        }
    }
}
