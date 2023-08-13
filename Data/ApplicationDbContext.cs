using ILibrary_BuyBooksOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ILibrary_BuyBooksOnline.Data
{
    public class ApplicationDbContext : IdentityDbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ILibraryBooks> ILibraryBook { get; set; }
        public object ILibraryBooks { get; internal set; }

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

            modelBuilder.Entity<ILibraryBooks>().HasData(
               new ILibraryBooks
               {
                   Id = 1,
                   Title = "Crack the coding Interview",
                   Author = "Gayle Laakmann McDowell",
                   Description = "Learn how to uncover the hints and hidden details in a question, discover how to break down a problem into manageable chunks, develop techniques to unstick yourself when stuck, learn (or re-learn) core computer science concepts, and practice on 189 interview questions and solutions.",
                   ISBN = "0984782869",
                   ListPrice = 150,
                   Price = 120,
                   Price50 = 100,
                   Price100 = 80,
                   ImageUrl = ""
               },
                new ILibraryBooks
                {
                    Id = 2,
                    Title = "Dressed up as Love - Second edition: A compelling tale of romance",
                    Author = "Lolo",
                    Description = "Hooked!! Dressed Up As Love is brilliantly written. Right from the start you are fully invested in the characters. I could totally identify with Melissa… I kinda wish I could go back in time and give this book to my younger self. Sincerely hope this book gets made into a film - brilliant” -Catherine Tyldesley ",
                    ISBN = "1916237738",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 3,
                    Title = "Bigger Leaner Stronger: The Simple Science of Building the Ultimate Male Body",
                    Author = "Michael",
                    Description = "His simple and science-based approach to building muscle, losing fat, and getting healthy has helped tens of thousands of people build their best body ever, and his work has been featured in many popular outlets including Esquire, Men’s Health, Elle, Women’s Health, Muscle & Strength, and more, as well as on FOX and ABC. ",
                    ISBN = "RITO55555011938895444",
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 4,
                    Title = "Dishoom: The first ever cookbook",
                    Author = "Shamil",
                    Description = "An eccentric and charming cookbook from Dishoom, with over 100 recipes from the much-loved restaurants ",
                    ISBN = "1408890674",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 5,
                    Title = "History: From the Dawn of Civilization to the Present Day",
                    Author = "DK",
                    Description = "Human endeavour and achievement is charted and celebrated from every angle, alongside key events, groundbreaking ideas, political forces, and technological advances that have shaped our planet's progress. ",
                    ISBN = "0241201306",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 6,
                    Title = "The 7 Pillars of Habit Building and Self-Discipline",
                    Author = "Neil Cooper",
                    Description = "If you’re stuck in a cycle of bad habits, procrastination, and laziness, then it’s time to learn how to master the art of building better habits and self-discipline!",
                    ISBN = "1961398044",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 7,
                    Title = "Where's Grogu?: A Star Wars: The Mandalorian Search and Find Activity Book",
                    Author = "Gayle Laakmann McDowell",
                    Description = "Star Wars fans of all ages will enjoy journeying to Nevarro, Tatooine, Arvala-7 and other locations throughout the galaxy in this interactive search-and-find.",
                    ISBN = "0984782869",
                    ListPrice = 150,
                    Price = 120,
                    Price50 = 100,
                    Price100 = 80,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 8,
                    Title = "Where's Spidey?: A Marvel Spider-Man search & find book",
                    Author = "Lolo",
                    Description = "An action-packed Spider-Man search-and-find book with original illustrations, to celebrate Spidey's 60th anniversary!",
                    ISBN = "1916237738",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 9,
                    Title = "Python Programming for Beginners",
                    Author = "Imran",
                    Description = "And that's where PYTHON, the most in-demand programming language in the world, comes in! ",
                    ISBN = "RITO55555011938895444e",
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    ImageUrl = ""

                },
                new ILibraryBooks
                {
                    Id = 10,
                    Title = "The Cottage: The gripping new 2021 crime suspense thriller with a difference",
                    Author = "Badley",
                    Description = "After losing her job and boyfriend, Jan Hamlin is in desperate need of a fresh start. So she jumps at the chance to rent a secluded cottage on the edge of Coleshaw Woods. ",
                    ISBN = "1408890674",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    ImageUrl = ""

                }
                );


        }
    }
}
