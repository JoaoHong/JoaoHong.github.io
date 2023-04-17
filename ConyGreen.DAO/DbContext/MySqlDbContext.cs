using System;
using System.Collections.Generic;
using ConyGreen.DAO.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.DAO.DbContext;

public partial class MySqlDbContext : IdentityDbContext<AspNetUser>
{
    public MySqlDbContext()
    {
    }

    public MySqlDbContext(DbContextOptions<MySqlDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LogAcesso> LogAcesso { get; set; }

    public virtual DbSet<Modelos> Modelos { get; set; }

    public virtual DbSet<Pesquisa> Pesquisa { get; set; }

    public virtual DbSet<Romaneio> Romaneio { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		if (!optionsBuilder.IsConfigured)
		{
			var configuration = new ConfigurationBuilder().AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), @"../ConyGreen.API/appsettings.json")).Build();
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

        modelBuilder.Entity<LogAcesso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LogAcesso).HasConstraintName("IdUsuarioFK");
        });

        modelBuilder.Entity<Modelos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Pesquisa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Romaneio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
