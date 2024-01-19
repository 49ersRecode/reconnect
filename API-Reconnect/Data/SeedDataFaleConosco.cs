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
                new FaleConosco { Id = 1, Nome = "Moraes", Email = "moraes@com", Mensagem = "Gostei muito do sistema, mas gostaria de trocar minha senha.", Status = false },
                new FaleConosco { Id = 2, Nome = "Antony Stark", Email = "antoinho@com", Mensagem = "Como faço para me cadastrar sem ter um telefone?", Status = false },
                new FaleConosco { Id = 3, Nome = "Fernanda Kipper", Email = "nando@com", Mensagem = "Gostaria de saber como cadasro meu serviço.", Status = false }
            );
        }
    }
}
