using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CakeDigitalFactory.Services.Models
{
    public partial class CakeDigitalFactoryDBContext : DbContext
    {
        public CakeDigitalFactoryDBContext()
        {
        }

        public CakeDigitalFactoryDBContext(DbContextOptions<CakeDigitalFactoryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Encargo> Encargos { get; set; }
        public virtual DbSet<Tienda> Tienda { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=CakeDigitalFactoryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Encargo>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(e => e.FechaEncargo)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEncargo");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEnvio");

                entity.Property(e => e.FechaRecibido)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRecibido");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseIdentityColumn();

                entity.Property(e => e.IdTienda).HasColumnName("idTienda");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusOrden");
            });

            modelBuilder.Entity<Tienda>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(e => e.CorreoTienda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correoTienda");

                entity.Property(e => e.DireccionTienda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccionTienda");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseIdentityColumn();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NombreTienda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreTienda");

                entity.Property(e => e.TelefonoTienda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoTienda");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.ToTable("Usuario");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseIdentityColumn();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Venta>(entity =>
            {

                entity.HasKey(x => x.Id);
                entity.Property(e => e.FechaVenta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaVenta");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseIdentityColumn();

                entity.Property(e => e.IdEncargo).HasColumnName("idEncargo");

                entity.Property(e => e.IdTienda).HasColumnName("idTienda");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NumCai).HasColumnName("numCai");

                entity.Property(e => e.NumCorrelativo).HasColumnName("numCorrelativo");

                entity.Property(e => e.NumFactura).HasColumnName("numFactura");

                entity.Property(e => e.TotalVenta).HasColumnName("totalVenta");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
