using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa", "dbo");
            builder.HasKey("EmpresaID");
            builder.Property(t => t.EmpresaID).HasColumnName("EmpresaID").HasColumnType("int");
            builder.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("varchar(40)");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");
        }
    }
}
