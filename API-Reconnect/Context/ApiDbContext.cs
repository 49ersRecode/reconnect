using API_Reconnect.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Reconnect.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<FaleConosco> FaleConosco { get; set; }

    }
}
