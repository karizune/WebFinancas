using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping
{
    public class PlanoContaTipoMap : IEntityTypeConfiguration<PlanoContaTipo>
    {
        public void Configure(EntityTypeBuilder<PlanoContaTipo> builder)
        {
            builder.ToTable("PlanoContaTipo", "dbo");
            builder.HasKey("PlanoContaTipoID");
            builder.Property(t => t.PlanoContaTipoID).HasColumnName("PlanoContaTipoID").HasColumnType("int");
            builder.Property(t => t.Codigo).HasColumnName("Codigo").HasColumnType("varchar(1)");
            builder.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("varchar(50)");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");

        }
    }
}
