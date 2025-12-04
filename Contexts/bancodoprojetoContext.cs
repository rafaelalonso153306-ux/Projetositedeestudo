using Microsoft.EntityFrameworkCore;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Contexts
{
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

<<<<<<< HEAD
    public virtual DbSet<Materium> Materia { get; set; }
=======
        public virtual DbSet<Materium> Materia { get; set; }
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bancodoprojeto;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
<<<<<<< HEAD
            entity.HasKey(e => e.Id).HasName("PK__Atividad__3213E83F148A3147");
=======
            modelBuilder.Entity<Atividade>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Atividad__3213E83F9F3A37D8");
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

                entity.ToTable("Atividade");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.ConteudoId).HasColumnName("Conteudo_id");
                entity.Property(e => e.Nota).HasColumnName("nota");
                entity.Property(e => e.UsuarioId).HasColumnName("Usuario_id");

<<<<<<< HEAD
            entity.HasOne(d => d.Conteudo).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.ConteudoId)
                .HasConstraintName("FK__Atividade__Conte__5DCAEF64");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Atividade__Usuar__5CD6CB2B");
        });

        modelBuilder.Entity<Conteudo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conteudo__3213E83F101FD794");
=======
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
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

                entity.ToTable("Conteudo");

<<<<<<< HEAD
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CursoId).HasColumnName("Curso_id");
            entity.Property(e => e.Nome)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.Curso).WithMany(p => p.Conteudos)
                .HasForeignKey(d => d.CursoId)
                .HasConstraintName("FK__Conteudo__Curso___59FA5E80");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curso__3213E83FA3AC024C");
=======
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
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

                entity.ToTable("Curso");

<<<<<<< HEAD
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");
            entity.Property(e => e.Descricao)
                .HasColumnType("text")
                .HasColumnName("descricao");
            entity.Property(e => e.Imagem)
                .HasMaxLength(255)
                .IsUnicode(false);
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
                .HasConstraintName("FK__Curso__Materia_i__571DF1D5");
        });

        modelBuilder.Entity<MateriaUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MateriaU__3213E83FAE114D7A");
=======
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");
                entity.Property(e => e.Descricao)
                    .HasColumnType("text")
                    .HasColumnName("descricao");
                entity.Property(e => e.Imagem)
                    .HasMaxLength(60)
                    .IsUnicode(false);
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
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

                entity.ToTable("MateriaUsuario");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.MateriaId).HasColumnName("Materia_id");
                entity.Property(e => e.UsuarioId).HasColumnName("Usuario_id");

<<<<<<< HEAD
            entity.HasOne(d => d.Materia).WithMany(p => p.MateriaUsuarios)
                .HasForeignKey(d => d.MateriaId)
                .HasConstraintName("FK__MateriaUs__Mater__534D60F1");

            entity.HasOne(d => d.Usuario).WithMany(p => p.MateriaUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__MateriaUs__Usuar__52593CB8");
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Materia__3213E83FEB9A85E2");
=======
                entity.HasOne(d => d.Materia).WithMany(p => p.MateriaUsuarios)
                    .HasForeignKey(d => d.MateriaId)
                    .HasConstraintName("FK__MateriaUs__Mater__4E88ABD4");

                entity.HasOne(d => d.Usuario).WithMany(p => p.MateriaUsuarios)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__MateriaUs__Usuar__4D94879B");
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Materia__3213E83FC78F0C9A");
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nome)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

<<<<<<< HEAD
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83FBF5FDABA");
=======
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83FE210F5ED");
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9

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

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
<<<<<<< HEAD

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
=======
>>>>>>> fca9f69ced79134538f9fc164bc72c6f512c28c9
}
