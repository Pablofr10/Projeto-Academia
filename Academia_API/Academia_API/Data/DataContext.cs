using Academia_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Endereco)
                .WithOne(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Telefone)
                .WithOne(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa);
        }
    }
}