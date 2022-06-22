using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityFramework.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "dbo");
            builder.HasKey("UsuarioID");
            builder.Property(t => t.UsuarioID).HasColumnName("UsuarioID").HasColumnType("intz");
            builder.Property(t => t.UsuarioAcesso).HasColumnName("UsuarioAcesso").HasColumnType("varchar(50)");
            builder.Property(t => t.Senha).HasColumnName("Senha").HasColumnType("varchar(50)");
            builder.Property(t => t.NomeUsuario).HasColumnName("NomeUsuario").HasColumnType("varchar(50)");
            builder.Property(t => t._usuario).HasColumnName("Usuario").HasColumnType("varchar(50)");
            builder.Property(t => t.Status).HasColumnName("Status").HasColumnType("bit");
            builder.Property(t => t.CriadoEm).HasColumnName("CriadoEm").HasColumnType("datetime");
            builder.Property(t => t.AtualizadoEm).HasColumnName("AtualizadoEm").HasColumnType("datetime");
        }
    }
}
