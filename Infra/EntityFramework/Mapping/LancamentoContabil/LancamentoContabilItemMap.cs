using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping
{
    public class LancamentoContabilItemMap : IEntityTypeConfiguration<LancamentoContabilItem>
    {
        public void Configure(EntityTypeBuilder<LancamentoContabilItem> builder)
        {
            builder.ToTable("LancamentoContabilItem", "dbo");
            builder.HasKey("LancamentoContabilItemID");
            builder.Property(t => t.LancamentoContabilItemID).HasColumnName("LancamentoContabilItemID").HasColumnType("int");
            builder.Property(t => t.LancamentoContabilID).HasColumnName("LancamentoContabilID").HasColumnType("int");
            builder.Property(t => t.LancamentoTipoID).HasColumnName("LancamentoTipoID").HasColumnType("int");
            builder.Property(t => t.EmpresaID).HasColumnName("EmpresaID").HasColumnType("int");
            builder.Property(t => t.CodigoContabil).HasColumnName("CodigoContabil").HasColumnType("varchar(7)");
            builder.Property(t => t.Valor).HasColumnName("Valor").HasColumnType("money");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");

        }
    }
}
