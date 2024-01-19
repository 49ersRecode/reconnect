using API_Reconnect.Data;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DataConnection")
                    .UseLazyLoadingProxies()
                    .EnableSensitiveDataLogging();

                this.Database.EnsureCreated();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedDataConfiguration());
            modelBuilder.ApplyConfiguration(new SeedDataServico());
            modelBuilder.ApplyConfiguration(new SeedDataContrato());
            modelBuilder.ApplyConfiguration(new SeedDataContato());
            modelBuilder.ApplyConfiguration(new SeedDataFaleConosco());

            base.OnModelCreating(modelBuilder);
        }
    }
}
