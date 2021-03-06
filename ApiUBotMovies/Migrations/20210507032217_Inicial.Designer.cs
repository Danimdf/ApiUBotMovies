// <auto-generated />
using ApiUBotMovies.Properties.Domain_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiUBotMovies.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210507032217_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ApiUBotMovies.Properties.Domain_Entity.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasPrecision(4)
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 2014,
                            Nome = "Guardiões da Galáxia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
