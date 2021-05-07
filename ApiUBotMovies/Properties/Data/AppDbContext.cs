using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUBotMovies.Properties.Domain_Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(p => p.Nome)
                    .HasMaxLength(90);

            modelBuilder.Entity<Movie>()
                .Property(p => p.Ano)
                    .HasPrecision(4);

            modelBuilder.Entity<Movie>()
                .HasData(
                new Movie {Id = 1, Nome = "Guardiões da Galáxia", Ano = 2014 }
                );
        }
    }
}
