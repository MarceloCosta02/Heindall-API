using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Heindall_API.Mappings;

public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable(nameof(Usuario).ToUpper());

        builder.HasKey(p => new { p.Id });

        builder.Property(p => p.Id)
           .HasColumnName(nameof(Usuario.Id).ToUpper())
           .IsRequired();

        builder.Property(p => p.Cnpj)
            .HasColumnName(nameof(Usuario.Cnpj).ToUpper())
            .IsRequired()
            .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.NomeEmpresa)
            .HasColumnName(nameof(Usuario.NomeEmpresa).ToUpper())
            .IsRequired()
            .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.HostBd)
           .HasColumnName(nameof(Usuario.HostBd).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.UserBd)
           .HasColumnName(nameof(Usuario.UserBd).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.SenhaBd)
           .HasColumnName(nameof(Usuario.SenhaBd).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.PortaBd)
           .HasColumnName(nameof(Usuario.PortaBd).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.SchemaBd)
           .HasColumnName(nameof(Usuario.SchemaBd).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");
    }
}
