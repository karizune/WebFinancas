using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping 
{ 
    public class LancamentoTipoMap : IEntityTypeConfiguration<LancamentoTipo>
    {
        public void Configure(EntityTypeBuilder<LancamentoTipo> builder)
        {
            builder.ToTable("LancamentoTipo", "dbo");
            builder.HasKey("LancamentoTipoID");
            builder.Property(t => t.LancamentoTipoID).HasColumnName("LancamentoTipoID").HasColumnType("int");
            builder.Property(t => t.Codigo).HasColumnName("Codigo").HasColumnType("varchar(2)");
            builder.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("varchar(40)");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");

        }
    }
}
