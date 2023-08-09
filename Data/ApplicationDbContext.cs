using ILibrary_BuyBooksOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace ILibrary_BuyBooksOnline.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Thriller", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Science", DisplayOrder = 2 },
                new Category { Id = 3, Name = "IT", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Kid", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Historical", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Horror", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Romance", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Fitness", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Cooking", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Personal Development", DisplayOrder = 10 }
                );


        }
    }
}
