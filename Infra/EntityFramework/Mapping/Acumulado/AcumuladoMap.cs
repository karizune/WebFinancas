using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping
{
    public class AcumuladoMap : IEntityTypeConfiguration<Acumulado>
    {
        public void Configure(EntityTypeBuilder<Acumulado> builder)
        {
            builder.ToTable("Acumulado", "dbo");
            builder.HasKey("AcumuladoID");
            builder.Property(t => t.AcumuladoID).HasColumnName("AcumuladoID").HasColumnType("int");
            builder.Property(t => t.EmpresaID).HasColumnName("EmpresaID").HasColumnType("int");
            builder.Property(t => t.CodigoContabil).HasColumnName("CodigoContabil").HasColumnType("varchar(7)");
            builder.Property(t => t.MesAno).HasColumnName("MesAno").HasColumnType("varchar(7)");
            builder.Property(t => t.Usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");
        }
    }
}
