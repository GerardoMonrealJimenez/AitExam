﻿// <auto-generated />
using System;
using Ait.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ait.WebApi.Migrations
{
    [DbContext(typeof(AitContext))]
    [Migration("20200710223622_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ait.Models.Products", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CantidadInventario")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Costo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdProduct");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ait.Models.Users", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Activo")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
