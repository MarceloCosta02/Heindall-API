using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Heindall_API.Mappings;

public class IntegradorDoUsuarioMapping : IEntityTypeConfiguration<IntegradorDoUsuario>
{
    public void Configure(EntityTypeBuilder<IntegradorDoUsuario> builder)
    {
        builder.ToTable(nameof(IntegradorDoUsuario).ToUpper());

        builder.HasKey(p => new { p.Id });

        builder.Property(p => p.Id)
           .HasColumnName(nameof(IntegradorDoUsuario.Id).ToUpper())
           .IsRequired();

        builder.Property(p => p.UsuarioIdAgencia)
            .HasColumnName(nameof(IntegradorDoUsuario.UsuarioIdAgencia).ToUpper())
            .IsRequired()
            .HasColumnType("INT");

        builder.Property(p => p.LoginIntegradorUsuario)
           .HasColumnName(nameof(IntegradorDoUsuario.LoginIntegradorUsuario).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.SenhaIntegradorUsuario)
           .HasColumnName(nameof(IntegradorDoUsuario.SenhaIntegradorUsuario).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.PortaIntegradorUsuario)
          .HasColumnName(nameof(IntegradorDoUsuario.PortaIntegradorUsuario).ToUpper())
          .IsRequired()
          .HasColumnType("INT");

        builder.Property(p => p.PublicKeyIntegradorUsuario)
           .HasColumnName(nameof(IntegradorDoUsuario.PublicKeyIntegradorUsuario).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.PrivateKeyIntegradorUsuario)
           .HasColumnName(nameof(IntegradorDoUsuario.PrivateKeyIntegradorUsuario).ToUpper())
           .IsRequired()
           .HasColumnType("VARCHAR(100)");
    }
}
