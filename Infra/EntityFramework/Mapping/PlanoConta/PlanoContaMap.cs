using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping 
{
    public class PlanoContaMap : IEntityTypeConfiguration<PlanoConta>
    {
        public void Configure(EntityTypeBuilder<PlanoConta> builder)
        {
            builder.ToTable("PlanoConta", "dbo");
            builder.HasKey("PlanoContaID");
            builder.Property(t => t.PlanoContaID).HasColumnName("PlanoContaID").HasColumnType("int");
            builder.Property(t => t.EmpresaID).HasColumnName("EmpresaID").HasColumnType("int");
            builder.Property(t => t.PlanoContaTipoID).HasColumnName("PlanoContaTipoID").HasColumnType("int");
            builder.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("varchar(40)");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");
        }
    }
}
