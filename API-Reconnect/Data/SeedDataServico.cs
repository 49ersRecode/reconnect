using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Reconnect.Data
{
    public class SeedDataServico : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.HasData(
                new Servico { Id = 1, Nome = "Ensino", Descricao = "Serviços de professores", UsuarioId = 3 },
                new Servico { Id = 2, Nome = "Construção", Descricao = "Reformas de todos os tipos", UsuarioId = 1 },
                new Servico { Id = 3, Nome = "Motorista", Descricao = "Motorista de aplicativo", UsuarioId = 3 }
            );
        }
    }
}
