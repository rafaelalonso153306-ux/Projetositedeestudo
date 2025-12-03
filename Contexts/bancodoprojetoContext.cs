using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Contexts;

public partial class BancoDoProjetoContext : DbContext
{
    public BancoDoProjetoContext()
    {
    }

    public BancoDoProjetoContext(DbContextOptions<BancoDoProjetoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<Conteudo> Conteudos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<MateriaUsuario> MateriaUsuarios { get; set; }

    public virtual DbSet<Materia> Materia { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bancodoprojeto;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3213E83F9F3A37D8");

            entity.ToTable("Atividade");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConteudoId).HasColumnName("Conteudo_id");
            entity.Property(e => e.Nota).HasColumnName("nota");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_id");

            entity.HasOne(d => d.Conteudo).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.ConteudoId)
                .HasConstraintName("FK__Atividade__Conte__5812160E");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Atividade__Usuar__571DF1D5");
        });

        modelBuilder.Entity<Conteudo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conteudo__3213E83F2558846E");

            entity.ToTable("Conteudo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CursoId).HasColumnName("Curso_id");
            entity.Property(e => e.Nome).HasColumnType("text");

            entity.HasOne(d => d.Curso).WithMany(p => p.Conteudos)
                .HasForeignKey(d => d.CursoId)
                .HasConstraintName("FK__Conteudo__Curso___5441852A");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curso__3213E83FE7E8414C");

            entity.ToTable("Curso");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");
            entity.Property(e => e.Descricao)
                .HasColumnType("text")
                .HasColumnName("descricao");
            entity.Property(e => e.MateriaId).HasColumnName("Materia_id");
            entity.Property(e => e.NivelDificuldade)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nivelDificuldade");
            entity.Property(e => e.Titulo)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.Materia).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.MateriaId)
                .HasConstraintName("FK__Curso__Materia_i__5165187F");
        });

        modelBuilder.Entity<MateriaUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MateriaU__3213E83FCB14BB37");

            entity.ToTable("MateriaUsuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MateriaId).HasColumnName("Materia_id");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_id");

            entity.HasOne(d => d.Materia).WithMany(p => p.MateriaUsuarios)
                .HasForeignKey(d => d.MateriaId)
                .HasConstraintName("FK__MateriaUs__Mater__4E88ABD4");

            entity.HasOne(d => d.Usuario).WithMany(p => p.MateriaUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__MateriaUs__Usuar__4D94879B");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Materia__3213E83FC78F0C9A");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83FE210F5ED");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    internal void Remove(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
