using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Reconnect.Data
{
    public class SeedDataContrato : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.HasData(
                new Contrato { Id = 1, Endereco = "Rua do chinelo, 20", DataHora= DateTime.Parse("2024-02-18T15:00:00"), Concluido= false, UsuarioId=2, ServicoId=2  },
                new Contrato { Id = 2, Endereco = "Rua do Ensino Fundamental, 50", DataHora = DateTime.Parse("2024-02-21T11:00:00"), Concluido = false, UsuarioId = 3, ServicoId = 1 },
                new Contrato { Id = 3, Endereco = "Avenida Perdida, 120", DataHora = DateTime.Parse("2024-03-15T10:00:00"), Concluido = false, UsuarioId = 2, ServicoId = 3 }
            );
        }
    }
}
