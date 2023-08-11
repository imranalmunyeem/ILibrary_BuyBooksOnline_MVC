using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILibrary_BuyBooksOnline.Migrations
{
    /// <inheritdoc />
    public partial class ILibraryBooks : Migration
    {
        public object Name { get; internal set; }
        public string Title { get; internal set; }

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "ILibraryBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILibraryBook", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ILibraryBook",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Gayle Laakmann McDowell", "Learn how to uncover the hints and hidden details in a question, discover how to break down a problem into manageable chunks, develop techniques to unstick yourself when stuck, learn (or re-learn) core computer science concepts, and practice on 189 interview questions and solutions.", "0984782869", 150.0, 120.0, 80.0, 100.0, "Crack the coding Interview" },
                    { 2, "Lolo", "Hooked!! Dressed Up As Love is brilliantly written. Right from the start you are fully invested in the characters. I could totally identify with Melissa… I kinda wish I could go back in time and give this book to my younger self. Sincerely hope this book gets made into a film - brilliant” -Catherine Tyldesley ", "1916237738", 40.0, 30.0, 20.0, 25.0, "Dressed up as Love - Second edition: A compelling tale of romance" },
                    { 3, "Michael", "His simple and science-based approach to building muscle, losing fat, and getting healthy has helped tens of thousands of people build their best body ever, and his work has been featured in many popular outlets including Esquire, Men’s Health, Elle, Women’s Health, Muscle & Strength, and more, as well as on FOX and ABC. ", "RITO55555011938895444", 0.0, 50.0, 35.0, 40.0, "Bigger Leaner Stronger: The Simple Science of Building the Ultimate Male Body" },
                    { 4, "Shamil", "An eccentric and charming cookbook from Dishoom, with over 100 recipes from the much-loved restaurants ", "1408890674", 70.0, 65.0, 55.0, 60.0, "Dishoom: The first ever cookbook" },
                    { 5, "DK", "Human endeavour and achievement is charted and celebrated from every angle, alongside key events, groundbreaking ideas, political forces, and technological advances that have shaped our planet's progress. ", "0241201306", 30.0, 27.0, 20.0, 25.0, "History: From the Dawn of Civilization to the Present Day" },
                    { 6, "Neil Cooper", "If you’re stuck in a cycle of bad habits, procrastination, and laziness, then it’s time to learn how to master the art of building better habits and self-discipline!", "1961398044", 25.0, 23.0, 20.0, 22.0, "The 7 Pillars of Habit Building and Self-Discipline" },
                    { 7, "Gayle Laakmann McDowell", "Star Wars fans of all ages will enjoy journeying to Nevarro, Tatooine, Arvala-7 and other locations throughout the galaxy in this interactive search-and-find.", "0984782869", 150.0, 120.0, 80.0, 100.0, "Where's Grogu?: A Star Wars: The Mandalorian Search and Find Activity Book" },
                    { 8, "Lolo", "An action-packed Spider-Man search-and-find book with original illustrations, to celebrate Spidey's 60th anniversary!", "1916237738", 40.0, 30.0, 20.0, 25.0, "Where's Spidey?: A Marvel Spider-Man search & find book" },
                    { 9, "Imran", "And that's where PYTHON, the most in-demand programming language in the world, comes in! ", "RITO55555011938895444e", 0.0, 50.0, 35.0, 40.0, "Python Programming for Beginners" },
                    { 10, "Badley", "After losing her job and boyfriend, Jan Hamlin is in desperate need of a fresh start. So she jumps at the chance to rent a secluded cottage on the edge of Coleshaw Woods. ", "1408890674", 70.0, 65.0, 55.0, 60.0, "The Cottage: The gripping new 2021 crime suspense thriller with a difference" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ILibraryBook");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
