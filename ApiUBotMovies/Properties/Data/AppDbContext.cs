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
                new Movie { Id = 1, Nome = "Guardiões da Galáxia", Ano = 2014 },
                new Movie { Id = 2, Nome = "Senhor dos Anéis: O retorno do rei", Ano = 2003 },
                new Movie { Id = 3, Nome = "Vingadores: Guerra infinita", Ano = 2018 },
                new Movie { Id = 4, Nome = "O poderoso chefão", Ano = 1972}
                );
        }
    }
}
