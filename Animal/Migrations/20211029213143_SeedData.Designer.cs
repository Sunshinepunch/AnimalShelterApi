// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20211029213143_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Gender = "Male",
                            Name = "Ruffus",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 1,
                            Gender = "Male",
                            Name = "Fuzz Aldrin",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Pawpstar",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 2,
                            Gender = "Female",
                            Name = "DangerNoodle",
                            Species = "Ferret"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 10,
                            Gender = "Male",
                            Name = "Kats Meow",
                            Species = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
