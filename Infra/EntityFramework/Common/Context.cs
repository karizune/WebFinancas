using Domain.Models;
using Infra.EntityFramework.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infra.EntityFramework.Common
{
    public class Context : DbContext
    {
        public DbSet<PlanoContaTipo> PlanoContaTipo{ get; set; }
        public DbSet<Empresa> Empresa{ get; set; }
        public DbSet<Acumulado> Acumulado { get; set; }
        public DbSet<LancamentoTipo> LancamentoTipo { get; set; }
        public DbSet<PlanoConta> PlanoConta { get; set; }
        public DbSet<LancamentoContabil> LancamentoContabil { get; set; }
        public DbSet<LancamentoContabilItem> LancamentoContabilItem { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanoContaTipoMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new AcumuladoMap());
            modelBuilder.ApplyConfiguration(new LancamentoTipoMap());
            modelBuilder.ApplyConfiguration(new PlanoContaMap());
            modelBuilder.ApplyConfiguration(new LancamentoContabilMap());
            modelBuilder.ApplyConfiguration(new LancamentoContabilItemMap());
            modelBuilder.ApplyConfiguration(new ContaMap());
            modelBuilder.ApplyConfiguration(new GrupoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Data source = 127.0.0.1;
                database = Financeiro;
                user id = luan;
                password = luan;
            ");
        }
    }
}
