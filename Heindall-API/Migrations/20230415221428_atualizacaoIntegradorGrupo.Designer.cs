﻿// <auto-generated />
using System;
using Heindall_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Heindall_API.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20230415221428_atualizacaoIntegradorGrupo")]
    partial class atualizacaoIntegradorGrupo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Heindall_API.Models.Grupo", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<string>("GrupoArea")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoMetodo")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoName")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoPassword")
                        .HasColumnType("longtext");

                    b.Property<int>("GrupoPort")
                        .HasColumnType("int");

                    b.Property<string>("GrupoType")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoURL")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoUser")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateKey")
                        .HasColumnType("longtext");

                    b.Property<string>("PublicKey")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Heindall_API.Models.Integrador", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<long>("GrupoId")
                        .HasColumnType("bigint");

                    b.Property<string>("IntegradorEndpoint")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorGrupo")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorNome")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorPrivateKey")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorPublicKey")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Integradores");
                });

            modelBuilder.Entity("Heindall_API.Models.IntegradorDoUsuario", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<long?>("IntegradorId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginIntegradorUsuario")
                        .HasColumnType("longtext");

                    b.Property<int>("PortaIntegradorUsuario")
                        .HasColumnType("int");

                    b.Property<string>("PrivateKeyIntegradorUsuario")
                        .HasColumnType("longtext");

                    b.Property<string>("PublicKeyIntegradorUsuario")
                        .HasColumnType("longtext");

                    b.Property<string>("SenhaIntegradorUsuario")
                        .HasColumnType("longtext");

                    b.Property<long?>("UsuarioId")
                        .HasColumnType("bigint");

                    b.Property<int>("UsuarioIdAgencia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IntegradorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("IntegradoresdoUsuario");
                });

            modelBuilder.Entity("Heindall_API.Models.Meta", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<string>("Demanda")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime>("Finish")
                        .HasColumnType("Date");

                    b.Property<string>("Pendencia")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Prioridade")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Projeto")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Start")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.ToTable("Metas");
                });

            modelBuilder.Entity("Heindall_API.Models.Usuario", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<string>("Cnpj")
                        .HasColumnType("longtext");

                    b.Property<string>("HostBd")
                        .HasColumnType("longtext");

                    b.Property<string>("Nivel")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("PortaBd")
                        .HasColumnType("longtext");

                    b.Property<string>("SchemaBd")
                        .HasColumnType("longtext");

                    b.Property<string>("SenhaBd")
                        .HasColumnType("longtext");

                    b.Property<string>("UserBd")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Heindall_API.Models.Integrador", b =>
                {
                    b.HasOne("Heindall_API.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("Heindall_API.Models.IntegradorDoUsuario", b =>
                {
                    b.HasOne("Heindall_API.Models.Integrador", "Integrador")
                        .WithMany("UsuariosDoIntegrador")
                        .HasForeignKey("IntegradorId");

                    b.HasOne("Heindall_API.Models.Usuario", "Usuario")
                        .WithMany("IntegradoresDoUsuario")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Integrador");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Heindall_API.Models.Integrador", b =>
                {
                    b.Navigation("UsuariosDoIntegrador");
                });

            modelBuilder.Entity("Heindall_API.Models.Usuario", b =>
                {
                    b.Navigation("IntegradoresDoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
