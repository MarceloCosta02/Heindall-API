using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Heindall_API.Mappings;

public class IntegradorMapping : IEntityTypeConfiguration<Integrador>
{
    public void Configure(EntityTypeBuilder<Integrador> builder)
    {
        builder.ToTable(nameof(Integrador).ToUpper());

        builder.HasKey(p => new { p.Id });

        builder.Property(p => p.Id)
           .HasColumnName(nameof(Integrador.Id).ToUpper())
           .IsRequired();

        builder.Property(p => p.IntegradorNome)
            .HasColumnName(nameof(Integrador.IntegradorNome).ToUpper())
            .IsRequired()
            .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.IntegradorEndpoint)
            .HasColumnName(nameof(Integrador.IntegradorEndpoint).ToUpper())
            .IsRequired()
            .HasColumnType("VARCHAR(100)");

        builder.Property(p => p.IntegradorPublicKey)
            .HasColumnName(nameof(Integrador.IntegradorPublicKey).ToUpper())
            .IsRequired()
            .HasColumnType("VARCHAR(20)");

        builder.Property(p => p.IntegradorPrivateKey)
            .HasColumnName(nameof(Integrador.IntegradorPrivateKey).ToUpper())
            .IsRequired()
            .HasColumnType("VARCHAR(20)");

        builder.OwnsOne(p => p.Grupo, a =>
        {
            a.Property(po => po.GrupoName)
                .HasColumnName(nameof(Grupo.GrupoName).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoDescription)
                .HasColumnName(nameof(Grupo.GrupoDescription).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoArea)
                 .HasColumnName(nameof(Grupo.GrupoArea).ToUpper())
                 .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoURL)
                .HasColumnName(nameof(Grupo.GrupoURL).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoMetodo)
                .HasColumnName(nameof(Grupo.GrupoMetodo).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoType)
                .HasColumnName(nameof(Grupo.GrupoType).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoUser)
                .HasColumnName(nameof(Grupo.GrupoUser).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoPassword)
                .HasColumnName(nameof(Grupo.GrupoPassword).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.GrupoPort)
                .HasColumnName(nameof(Grupo.GrupoPort).ToUpper())
                .HasColumnType("INT");

            a.Property(po => po.PublicKey)
                .HasColumnName(nameof(Grupo.PublicKey).ToUpper())
                .HasColumnType("VARCHAR(100)");

            a.Property(po => po.PrivateKey)
                .HasColumnName(nameof(Grupo.PrivateKey).ToUpper())
                .HasColumnType("VARCHAR(100)");
        });
    }
}
