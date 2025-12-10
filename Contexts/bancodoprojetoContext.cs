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

    public virtual DbSet<AtividadesUsuario> AtividadesUsuarios { get; set; }

    public virtual DbSet<Conteudo> Conteudos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bancodoprojeto;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3214EC07CBA05E64");

            entity.ToTable("Atividade");

            entity.Property(e => e.ConteudoId).HasColumnName("Conteudo_id");
            entity.Property(e => e.DataConclusao).HasColumnType("datetime");
            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_id");

            entity.HasOne(d => d.Conteudo).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.ConteudoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atividade_Conteudo");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atividade_Usuario");
        });

        modelBuilder.Entity<AtividadesUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3213E83F431C2124");

            entity.ToTable("AtividadesUsuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AtividadeId).HasColumnName("Atividade_id");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_id");

            entity.HasOne(d => d.Atividade).WithMany(p => p.AtividadesUsuarios)
                .HasForeignKey(d => d.AtividadeId)
                .HasConstraintName("FK__Atividade__Ativi__5535A963");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AtividadesUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Atividade__Usuar__5441852A");
        });

        modelBuilder.Entity<Conteudo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conteudo__3214EC07D702769E");

            entity.ToTable("Conteudo");

            entity.Property(e => e.CursoId).HasColumnName("Curso_id");
            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Imagem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(160)
                .IsUnicode(false);

            entity.HasOne(d => d.Curso).WithMany(p => p.Conteudos)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Conteudo_Curso");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curso__3214EC07C7090501");

            entity.ToTable("Curso");

            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Imagem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MateriaId).HasColumnName("Materia_id");
            entity.Property(e => e.NivelDificuldade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(160)
                .IsUnicode(false);

            entity.HasOne(d => d.Materia).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.MateriaId)
                .HasConstraintName("FK_Curso_Materia");
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Materia__3214EC07F94B99E1");

            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Imagem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(160)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07233CA3C8");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105342CA9F70D").IsUnique();

            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NivelAcesso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
