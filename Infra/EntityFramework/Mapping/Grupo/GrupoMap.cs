using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupo", "dbo");
            builder.HasKey("GrupoID");
            builder.Property(t => t.GrupoID).HasColumnName("GrupoID").HasColumnType("int");
            builder.Property(t => t.CodigoGrupo).HasColumnName("CodigoGrupo").HasColumnType("int");
            builder.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("varchar(40)");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");
        }
    }
}
