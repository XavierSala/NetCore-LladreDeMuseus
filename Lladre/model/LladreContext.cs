using System;
using System.IO;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Lladre.Db
{

    public class LladreContext : DbContext
    {
        public virtual DbSet<Visita> Visites { get; set; }
        public virtual DbSet<Denuncia> Denuncies { get; set; }
        public virtual DbSet<Visitant> Visitants { get; set; }
        public virtual DbSet<Museu> Museus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            // .AddJsonFile("appsettings.json");

            // Configuration = builder.Build();

            // optionsBuilder.UseMySQL(Configuration["ConnectionStrings:DefaultConnectionStrings"]);
            optionsBuilder.UseMySql(@"Server=localhost;User=root;Password=ies2010;Database=lladres", mysqlOptions =>
                    {
                        mysqlOptions.ServerVersion(new Version(5, 7, 21), ServerType.MySql);
                    });
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Museu>()
            .HasMany(vi => vi.Visites)
            .WithOne(vi => vi.Museu);

            modelBuilder.Entity<Visitant>()
            .HasMany(vis => vis.Visites)
            .WithOne(vis => vis.Visitant);

            base.OnModelCreating(modelBuilder);
        }
    }
}