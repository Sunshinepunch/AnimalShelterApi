using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Animal>().HasData(
        new Animal { AnimalId = 1, Name = "Ruffus", Species = "Dog", Age = 7, Gender = "Male" },
        new Animal { AnimalId = 2, Name = "Fuzz Aldrin", Species = "Cat", Age = 1, Gender = "Male" },
        new Animal { AnimalId = 3, Name = "Pawpstar", Species = "Dog", Age = 2, Gender = "Female" },
        new Animal { AnimalId = 4, Name = "DangerNoodle", Species = "Ferret", Age = 2, Gender = "Female" },
        new Animal { AnimalId = 5, Name = "Kats Meow", Species = "Cat", Age = 10, Gender = "Male" }
            );
        }
    }
}