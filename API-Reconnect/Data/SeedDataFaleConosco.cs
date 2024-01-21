using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Reconnect.Data
{
    public class SeedDataFaleConosco : IEntityTypeConfiguration<FaleConosco>
    {
        public void Configure(EntityTypeBuilder<FaleConosco> builder)
        {
            builder.HasData(
                new FaleConosco { Id = 1, Nome = "Loiane", Email = "loiane@com", Mensagem = "Gostei muito do sistema, gostaria de trocar minha senha.", Status = false },
                new FaleConosco { Id = 2, Nome = "Antony Stark", Email = "antoinho@com", Mensagem = "Como faço para me cadastrar sem ter um telefone?", Status = false },
                new FaleConosco { Id = 3, Nome = "Fernanda Kipper", Email = "nanda@com", Mensagem = "Gostaria de saber como cadastro meu serviço.", Status = false }
            );
        }
    }
}
