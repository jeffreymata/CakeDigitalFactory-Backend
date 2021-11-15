﻿// <auto-generated />
using System;
using CakeDigitalFactory.Services.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CakeDigitalFactory.Services.Migrations
{
    [DbContext(typeof(CakeDigitalFactoryDBContext))]
    [Migration("20211111024909_addingProductTable")]
    partial class addingProductTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CakeDigitalFactory.Services.Models.Encargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaEncargo")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaEncargo");

                    b.Property<DateTime?>("FechaEnvio")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaEnvio");

                    b.Property<DateTime?>("FechaRecibido")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaRecibido");

                    b.Property<int?>("IdTienda")
                        .HasColumnType("int")
                        .HasColumnName("idTienda");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("idUsuario");

                    b.Property<string>("StatusOrden")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("statusOrden");

                    b.HasKey("Id");

                    b.ToTable("Encargos");
                });

            modelBuilder.Entity("CakeDigitalFactory.Services.Models.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaRegistro");

                    b.Property<int>("IdTienda")
                        .HasColumnType("int")
                        .HasColumnName("IdTienda");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NombreProducto");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Precio");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CakeDigitalFactory.Services.Models.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoTienda")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correoTienda");

                    b.Property<string>("DireccionTienda")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccionTienda");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaCreacion");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("idUsuario");

                    b.Property<string>("NombreTienda")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreTienda");

                    b.Property<string>("TelefonoTienda")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("telefonoTienda");

                    b.HasKey("Id");

                    b.ToTable("Tienda");
                });

            modelBuilder.Entity("CakeDigitalFactory.Services.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaCreacion");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CakeDigitalFactory.Services.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaVenta")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaVenta");

                    b.Property<int?>("IdEncargo")
                        .HasColumnType("int")
                        .HasColumnName("idEncargo");

                    b.Property<int?>("IdTienda")
                        .HasColumnType("int")
                        .HasColumnName("idTienda");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("idUsuario");

                    b.Property<int?>("NumCai")
                        .HasColumnType("int")
                        .HasColumnName("numCai");

                    b.Property<int?>("NumCorrelativo")
                        .HasColumnType("int")
                        .HasColumnName("numCorrelativo");

                    b.Property<int?>("NumFactura")
                        .HasColumnType("int")
                        .HasColumnName("numFactura");

                    b.Property<int?>("TotalVenta")
                        .HasColumnType("int")
                        .HasColumnName("totalVenta");

                    b.HasKey("Id");

                    b.ToTable("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
