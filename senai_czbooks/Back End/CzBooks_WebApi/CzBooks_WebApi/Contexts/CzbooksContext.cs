using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CzBooks_WebApi.Domains;

#nullable disable

namespace CzBooks_WebApi.Contexts
{
    public partial class CzbooksContext : DbContext
    {
        public CzbooksContext()
        {
        }

        public CzbooksContext(DbContextOptions<CzbooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autores { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Livraria> Livrarias { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAB08DESK115999\\SQLEXPRESS; Initial Catalog=Czbooks; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__Autores__DD33B031EF258574");

                entity.Property(e => e.Nome)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Autores__IdUsuar__2E1BDC42");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A102F224ADE");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Livraria>(entity =>
            {
                entity.HasKey(e => e.IdLivraria)
                    .HasName("PK__Livraria__AC9443CBBDF0010A");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.IdLivro)
                    .HasName("PK__Livros__3B69D85A6A1E8AF1");

                entity.Property(e => e.DataPublicacao).HasColumnType("date");

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sinopse)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__Livros__IdAutor__32E0915F");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Livros__IdCatego__30F848ED");

                entity.HasOne(d => d.IdLivrariaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdLivraria)
                    .HasConstraintName("FK__Livros__IdLivrar__31EC6D26");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__CA04062B99C8C687");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF972024A5B1");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D10534C2F268F6")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__IdTipo__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
