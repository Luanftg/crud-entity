﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crud_entity.Contexto;

#nullable disable

namespace crudentity.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("crud_entity.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("carro");
                });

            modelBuilder.Entity("crud_entity.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("crud_entity.Models.Configuracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DiasLocacao")
                        .HasColumnType("int")
                        .HasColumnName("diasLocacao");

                    b.HasKey("Id");

                    b.ToTable("configuracao");
                });

            modelBuilder.Entity("crud_entity.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("marca");
                });

            modelBuilder.Entity("crud_entity.Models.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("modelo");
                });

            modelBuilder.Entity("crud_entity.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarroId")
                        .HasColumnType("int")
                        .HasColumnName("carroId");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("clienteId");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("DATETIME")
                        .HasColumnName("dataEntrega");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("DATETIME")
                        .HasColumnName("dataLocacao");

                    b.HasKey("Id");

                    b.ToTable("pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
