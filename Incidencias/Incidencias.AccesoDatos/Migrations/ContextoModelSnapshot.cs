﻿// <auto-generated />
using System;
using Incidencias.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Incidencias.AccesoDatos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Incidencias.Modelos.Incidencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstatusIncidencia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<float>("Version")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Incidencias");
                });

            modelBuilder.Entity("Incidencias.Modelos.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Administrador"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Desarrollador"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Tester"
                        });
                });

            modelBuilder.Entity("Incidencias.Modelos.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstatusProyecto")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proyectos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstatusProyecto = 1,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 186, DateTimeKind.Local).AddTicks(6832),
                            Nombre = "Alpina"
                        },
                        new
                        {
                            Id = 2,
                            EstatusProyecto = 1,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 187, DateTimeKind.Local).AddTicks(5104),
                            Nombre = "Bavaria"
                        },
                        new
                        {
                            Id = 3,
                            EstatusProyecto = 1,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 187, DateTimeKind.Local).AddTicks(5135),
                            Nombre = "Postobon"
                        });
                });

            modelBuilder.Entity("Incidencias.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerfilId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Somma",
                            Email = "agustina.somma@gsoft.com.uy",
                            Estatus = 1,
                            Nombre = "Agustina",
                            PerfilId = 1
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Valente",
                            Email = "valente@gsoft.com.uy",
                            Estatus = 1,
                            Nombre = "Viviana",
                            PerfilId = 2
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Wolfan",
                            Email = "valente@gsoft.com.uy",
                            Estatus = 1,
                            Nombre = "Jonathan",
                            PerfilId = 2
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "Rozo",
                            Email = "valente@gsoft.com.uy",
                            Estatus = 1,
                            Nombre = "Ingri",
                            PerfilId = 2
                        },
                        new
                        {
                            Id = 5,
                            Apellidos = "Perez",
                            Email = "test@gsoft.com.uy",
                            Estatus = 1,
                            Nombre = "Juan",
                            PerfilId = 3
                        });
                });

            modelBuilder.Entity("Incidencias.Modelos.UsuariosProyectos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuariosProyectos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(1766),
                            ProyectoId = 1,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2568),
                            ProyectoId = 2,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 3,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2590),
                            ProyectoId = 3,
                            UsuarioId = 5
                        },
                        new
                        {
                            Id = 4,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2605),
                            ProyectoId = 1,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 5,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2618),
                            ProyectoId = 2,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 6,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2637),
                            ProyectoId = 2,
                            UsuarioId = 3
                        },
                        new
                        {
                            Id = 7,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2650),
                            ProyectoId = 2,
                            UsuarioId = 4
                        },
                        new
                        {
                            Id = 8,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2662),
                            ProyectoId = 2,
                            UsuarioId = 5
                        },
                        new
                        {
                            Id = 9,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2675),
                            ProyectoId = 3,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 10,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2690),
                            ProyectoId = 3,
                            UsuarioId = 4
                        },
                        new
                        {
                            Id = 11,
                            FechaRegistro = new DateTime(2021, 10, 1, 1, 16, 54, 188, DateTimeKind.Local).AddTicks(2703),
                            ProyectoId = 3,
                            UsuarioId = 5
                        });
                });

            modelBuilder.Entity("Incidencias.Modelos.Incidencia", b =>
                {
                    b.HasOne("Incidencias.Modelos.Proyecto", "Proyecto")
                        .WithMany("Incidencias")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("Incidencias.Modelos.Usuario", b =>
                {
                    b.HasOne("Incidencias.Modelos.Perfil", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Incidencias.Modelos.UsuariosProyectos", b =>
                {
                    b.HasOne("Incidencias.Modelos.Proyecto", "Proyecto")
                        .WithMany("UsuariosProyectos")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incidencias.Modelos.Usuario", "Usuario")
                        .WithMany("UsuariosProyectos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Incidencias.Modelos.Perfil", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Incidencias.Modelos.Proyecto", b =>
                {
                    b.Navigation("Incidencias");

                    b.Navigation("UsuariosProyectos");
                });

            modelBuilder.Entity("Incidencias.Modelos.Usuario", b =>
                {
                    b.Navigation("UsuariosProyectos");
                });
#pragma warning restore 612, 618
        }
    }
}