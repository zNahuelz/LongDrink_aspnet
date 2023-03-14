using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LongDrink_aspnet.Models;

public partial class LongDrinkContext : DbContext
{
    public LongDrinkContext()
    {
    }

    public LongDrinkContext(DbContextOptions<LongDrinkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Clase> Clases { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<Inscripcion> Inscripcions { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<ProfesorCurso> ProfesorCursos { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioAlumno> UsuarioAlumnos { get; set; }

    public virtual DbSet<UsuarioProfesor> UsuarioProfesors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source=BLACKMESA;initial catalog=LongDrink;integrated security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.IdAlumno).HasName("PK__Alumno__6D77A7F177FAC4F4");

            entity.ToTable("Alumno");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.ApMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ap_materno");
            entity.Property(e => e.ApPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ap_paterno");
            entity.Property(e => e.Dni)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Clase>(entity =>
        {
            entity.HasKey(e => e.IdClase).HasName("PK__Clases__2352EEDB4714D63F");

            entity.Property(e => e.IdClase).HasColumnName("id_clase");
            entity.Property(e => e.Guia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("guia");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Clases)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK_CsC");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("PK__Curso__5D3F7502E2DDD62D");

            entity.ToTable("Curso");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad).HasName("PK__Especial__C1D13763BFFE0576");

            entity.ToTable("Especialidad");

            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");
            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.Especialidads)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK_EpP");
        });

        modelBuilder.Entity<Inscripcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inscripcion");

            entity.Property(e => e.EnCurso).HasColumnName("en_curso");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("date")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("date")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaInscripcion)
                .HasColumnType("date")
                .HasColumnName("fecha_inscripcion");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany()
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK_IcA");

            entity.HasOne(d => d.IdCursoNavigation).WithMany()
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK_IcC");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.IdProfesor).HasName("PK__Profesor__159ED61710128DD7");

            entity.ToTable("Profesor");

            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.ApMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ap_materno");
            entity.Property(e => e.ApPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ap_paterno");
            entity.Property(e => e.Dni)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ProfesorCurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Profesor_Curso");

            entity.Property(e => e.FechaFinal)
                .HasColumnType("date")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("date")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");

            entity.HasOne(d => d.IdCursoNavigation).WithMany()
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK_PcC");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany()
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK_PcP");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.IdTurno).HasName("PK__Turnos__C68E73977A3D090B");

            entity.Property(e => e.IdTurno).HasColumnName("id_turno");
            entity.Property(e => e.HoraFinal).HasColumnName("hora_final");
            entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK_TnC");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__4E3E04AD3A65A080");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.Permisos).HasColumnName("permisos");
        });

        modelBuilder.Entity<UsuarioAlumno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Usuario_Alumno");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany()
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK_UaA");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_UaU");
        });

        modelBuilder.Entity<UsuarioProfesor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Usuario_Profesor");

            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany()
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK_UpP");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_UpU");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
