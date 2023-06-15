using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VascoVasconcellos.DAO.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.AppDbContext;

public partial class MySqlDbContext : IdentityDbContext<AspNetUsers>
{
    public MySqlDbContext()
    {
    }

    public MySqlDbContext(DbContextOptions<MySqlDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Boleta> Boleta { get; set; }

    public virtual DbSet<Clientes> Clientes { get; set; }

    public virtual DbSet<Conjuntos> Conjuntos { get; set; }

    public virtual DbSet<Etiqueta> Etiqueta { get; set; }

    public virtual DbSet<LogAcesso> LogAcesso { get; set; }

    public virtual DbSet<LogErro> LogErro { get; set; }

    public virtual DbSet<LogOperacao> LogOperacao { get; set; }

    public virtual DbSet<Modelagem> Modelagem { get; set; }

    public virtual DbSet<Orcamentos> Orcamentos { get; set; }

    public virtual DbSet<Produtos> Produtos { get; set; }

    public virtual DbSet<ProdutosColunas> ProdutosColunas { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<Vendas> Vendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), @"../VascoVasconcellos.API/appsettings.json")).Build();
            var connectionString = configuration.GetConnectionString(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
            optionsBuilder.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString),
                options => options.CommandTimeout((int)TimeSpan.FromHours(1).TotalSeconds).EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null)
            );
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder
            .UseCollation("utf8_unicode_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Boleta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdOrcamentoNavigation).WithMany(p => p.Boleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Boleta_Orcamento_IdOrcamento");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Boleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Boleta_Usuario_IdVendedor");
        });

        modelBuilder.Entity<Clientes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Conjuntos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdVendaNavigation).WithMany(p => p.Conjuntos).HasConstraintName("Fk_Conjuntos_Vendas_IdVendas");
        });

        modelBuilder.Entity<Etiqueta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<LogAcesso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LogAcesso).HasConstraintName("FK_LogAcesso_Usuario");
        });

        modelBuilder.Entity<LogErro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LogErro).HasConstraintName("FK_LogErro_Usuario");
        });

        modelBuilder.Entity<LogOperacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LogOperacao).HasConstraintName("FK_LogOperacao_Usuario");
        });

        modelBuilder.Entity<Modelagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Orcamentos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdCompradorNavigation).WithMany(p => p.Orcamentos).HasConstraintName("Fk_Orcamento_Cliente_IdComprador");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Orcamentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Orcamento_Usuario_IdVendedor");
        });

        modelBuilder.Entity<Produtos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<ProdutosColunas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Vendas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdOrcamentoNavigation).WithMany(p => p.Vendas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Vendas_Orcamentos_IdOrcamento");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.Vendas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Vendas_Produto_IdProduto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Vendas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Vendas_Clientes_IdUsuario");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Vendas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Vendas_Usuario_IdVendedor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
