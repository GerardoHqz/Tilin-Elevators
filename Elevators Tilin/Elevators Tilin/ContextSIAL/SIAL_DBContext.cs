using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Elevators_Tilin.ContextSIAL
{
    public partial class SIAL_DBContext : DbContext
    {
        public SIAL_DBContext()
        {
        }

        public SIAL_DBContext(DbContextOptions<SIAL_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Automovil> Automovils { get; set; }
        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<Mantenimiento> Mantenimientos { get; set; }
        public virtual DbSet<Reparacion> Reparacions { get; set; }
        public virtual DbSet<ReparacionxRepuesto> ReparacionxRepuestos { get; set; }
        public virtual DbSet<Repuesto> Repuestos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SIAL_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Automovil>(entity =>
            {
                entity.ToTable("AUTOMOVIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.Combustuble)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COMBUSTUBLE");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MARCA");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MODELO");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PLACA");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.ToTable("EQUIPO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContratoFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("CONTRATO_FINAL");

                entity.Property(e => e.ContratoInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("CONTRATO_INICIO");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("MARCA");

                entity.Property(e => e.Niveles).HasColumnName("NIVELES");

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SERIE");

                entity.Property(e => e.Velocidad).HasColumnName("VELOCIDAD");

                entity.Property(e => e.Voltaje).HasColumnName("VOLTAJE");
            });

            modelBuilder.Entity<Mantenimiento>(entity =>
            {
                entity.ToTable("MANTENIMIENTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.FechaMantenimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MANTENIMIENTO");

                entity.Property(e => e.IdAutomovil).HasColumnName("ID_AUTOMOVIL");

                entity.Property(e => e.IdEquipo).HasColumnName("ID_EQUIPO");

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SERIE");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TECNICO");

                entity.HasOne(d => d.IdAutomovilNavigation)
                    .WithMany(p => p.Mantenimientos)
                    .HasForeignKey(d => d.IdAutomovil)
                    .HasConstraintName("FK__MANTENIMI__ID_AU__44FF419A");

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.Mantenimientos)
                    .HasForeignKey(d => d.IdEquipo)
                    .HasConstraintName("FK__MANTENIMI__ID_EQ__412EB0B6");
            });

            modelBuilder.Entity<Reparacion>(entity =>
            {
                entity.ToTable("REPARACION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.FechaReparacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REPARACION");

                entity.Property(e => e.IdAutomovil).HasColumnName("ID_AUTOMOVIL");

                entity.Property(e => e.IdEquipo).HasColumnName("ID_EQUIPO");

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SERIE");

                entity.Property(e => e.Tecnico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TECNICO");

                entity.HasOne(d => d.IdAutomovilNavigation)
                    .WithMany(p => p.Reparacions)
                    .HasForeignKey(d => d.IdAutomovil)
                    .HasConstraintName("FK__REPARACIO__ID_AU__440B1D61");

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.Reparacions)
                    .HasForeignKey(d => d.IdEquipo)
                    .HasConstraintName("FK__REPARACIO__ID_EQ__403A8C7D");
            });

            modelBuilder.Entity<ReparacionxRepuesto>(entity =>
            {
                entity.ToTable("REPARACIONxREPUESTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdReparacion).HasColumnName("ID_REPARACION");

                entity.Property(e => e.IdRepuesto).HasColumnName("ID_REPUESTO");

                entity.HasOne(d => d.IdReparacionNavigation)
                    .WithMany(p => p.ReparacionxRepuestos)
                    .HasForeignKey(d => d.IdReparacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPARACIO__ID_RE__4222D4EF");

                entity.HasOne(d => d.IdRepuestoNavigation)
                    .WithMany(p => p.ReparacionxRepuestos)
                    .HasForeignKey(d => d.IdRepuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPARACIO__ID_RE__4316F928");
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.ToTable("REPUESTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FABRICANTE");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MODELO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SERIE");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.TiempoSuministro).HasColumnName("TIEMPO_SUMINISTRO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
