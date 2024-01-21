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
                new Servico { Id = 1, Nome = "Ensino", Descricao = "Serviços de professores", UsuarioId = 2 },
                new Servico { Id = 2, Nome = "Motorista", Descricao = "Motorista de aplicativo", UsuarioId = 1 },
                new Servico { Id = 3, Nome = "Reforma", Descricao = "Reformas de todos os tipos", UsuarioId = 3 },

                new Servico { Id = 4, Nome = "Serviços Domésticos", Descricao = "Serviços de limpeza", UsuarioId = 4 },
                new Servico { Id = 5, Nome = "Mecânico", Descricao = "Reparo de automóveis", UsuarioId = 5 },
                new Servico { Id = 6, Nome = "Encanador", Descricao = "Serviços de encanador", UsuarioId = 6 },
                new Servico { Id = 7, Nome = "Personal", Descricao = "Serviços de Pesonal Trainer", UsuarioId = 7 },
                new Servico { Id = 8, Nome = "Cozinha", Descricao = "Serviços de cozinha", UsuarioId = 8 }
            );
        }
    }
}
