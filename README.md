# ILibrary_BuyBooksOnline

## Tools, Patterns and frameworks used in this project
    --- C#, .net 8.0
    --- MVC Pattern
    --- Entity Framework for Database
    --- html, CSS, BootStrap (qartz)
    --- Visual Studio Preview 
    --- Microsoft SQL Server Management Studio (SSMS) 

## Things used on this project 
    --- N-Tier Architecture
    --- Repository Pattern and UnitOfWork
    --- TempData/ViewBag/ViewData in .NET core
    --- API Controllers with Razor Pages
    --- SweetAlerts, Rich Text Editor and DataTables with .NET Core
    --- Scaffold Identity (Razor Class Library) 
    --- Roles and Authorization in .NET Core
    --- Stripe Payment/Refund with .NET Core
    --- Session in .NET Core
    --- Emails with SendGrid
    --- User Management
    --- Social Login using Facebook
    --- View Components in .NET Core
    --- Seed Database with DbInitializer
    --- Deploy to Azure

## Steps of Building this project from scratch:
### Step 1: Download the follwing tools:
    --- Download Microsoft Visual Studio Preview (https://visualstudio.microsoft.com/vs/preview/)
    --- Download Microsoft SQL Server Management Studio (SSMS) (https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
    --- Download SQL Server 2022 (https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
    --- Download bootstrap theme (https://bootswatch.com/) ->Add bootstrap.css file to wwwroot ->lib ->Bootstrap ->css

### Step 2: Create A new MVC project
    --- File -> New -> Project -> MVC -> Create

# ----------------------------------------------------------Build Category Page---------------------------------------------------------------------->
### Step 3: Create A new Class from the "Model" [N.B: It's not mandatory to create the class in model. But we usually do it in the model]
    --- Model ->Add ->Class ->Category.cs
##### [N.B. It's not mandatory to create the class in model. But we usually do it in the model. We have to make these classes before using entity framework]

### Step 4: Open SQL Server 
    --- Set up the required fields
    --- Use "sqlcmd -S IMRAN -E" to connect the server

### Step 5: Open SQL Server Management Studio
    --- Set up the required fields
    --- Select the created SQL Server "Imran"

### Step 6: Modify "appsettings.json" file to setup the connection string for database 
    ---   "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"
            }

### Step 7: Install the following packages from "Nuget Package manager"
    --- Microsoft.EntityFrameworkCore.SqlServer 8.00
    --- Microsoft.EntityFrameworkCore 8.00
    --- Microsoft.EntityFrameworkCore.Tools 8.00

### Step 8: Setup "ApplicationDBContext"
    --- Project ->Create A new folder ->Name it "Data" ->Add a class named "ApplicationDbContext.cs" under data folder

### Step 9: Configure "ApplicationDBContext" class

### Step 10: Link "ApplicationDbContext" to builder in "program.cs"
    --- Go to "Add services to the container." -> Add "builder.Services.AddDbContext<ILibrary_BuyBooksOnline.Data.ApplicationDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));"

### Step 11: To work with database follow the below steps
    --- Tools ->Nuget Package Manager ->Nuget Package manager Console
    --- In console, write the below commands:
                --- update-database             //It will display build succeeded if the DB connection is successful

### Step 12: To use "Entity Framework" for Table Creation
    --- Add "public DbSet<Category> Categories { get; set; }" to "ApplicationDbContext.cs"  //It will automatically create table using entity framework core
    --- Nuget package manager console ->add-migration AddCategoryTableToDb                  //It will automatically create category table under Migration folder
    --- Nuget package manager console ->update-database                                     // It will automatically access the table from Migration folder, convert to SQL, and add it to the "Microsoft SQL Server management System"

#### Step 13: Add "Category Controller"
    --- Controllers ->Add ->Controller ->MVC Controller-Empty ->Name it CategoryController

#### Step 14: Add "View" for the "Category Controller"
    --- Views -> Add Folder named "Category" -> Add "Index.cshtml" and "category.cshtml" here

#### Step 15: Add "Category" link to header
    --- Go to "_Layout.cshtml" -> Add "Category" to Navbar
            <li class="nav-item">
                <a class="nav-link text-dark" asp-area="" asp-controller="Category" asp-action="Index">Category</a>
            </li> 
##### [N.B: It will create the category navbar and show it]

#### Step 16: Seed entities to database from "ApplicationDbContext" file using "Override Model Builder"
    --- Data ->ApplicationDbContext -> Add " protected override void OnModelCreating(ModelBuilder modelBuilder)" ->Add categories depending you need
    --- Nuget package console ->add-migration SeedCategoryTable ->update-database           //It will update the database with categorylist

#### Step 17: Retrieve and dispplay the newly created categories in the view
    --- CategoryController -> Add the required modification to the category controller class        //It will retrieve data from database and display on views
    --- Pass the "objcategorylist" from controller class to "View"

#### Step 18: Add "Create" page for category
    --- Add "create" action method in CreateController file
    --- Add a create page under views of category
    --- Update the route ofr create page in index.cshtml file

#### Step 19: Add "Input Tags helper" to html pages to make it more dynamic
    --- For example:  Add <input asp-for="DisplayOrder"
    --- We don't need to add type as tag helper will automatically fetch it.

#### Step 20: Add "Server Side validation" 
    --- Use data notations in model file
    --- Use conditional statement in the action method in controller pages

#### Step 21: Add "Client Side validation" 
    --- Using "_ValidationScriptsPartial.cshtml" from shared folder, we can add client side validation
    --- Add below code in html pages to add client side validation
            @section Scripts{
                @{
                    <partial name="_ValidationScriptsPartial"/>
                        }
                    }

#### Step 22: Add "asp-route-id="@obj.Id" to dynamically routing for edit the categogry //user can put any page number

#### Step 23: Display notification using TempData
    --- For example, Go to Create controller and add "TempData["success"] = "Category created successfully";"

#### Step 24: Add "Toastr" notification which is more better and dynamic
    --- Add toastr from here (https://codeseven.github.io/toastr/)
    --- Add this (<link rel="stylesheet" href="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"/>) to _layout.cshtml
    --- Add this (<script src="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>) to individual notifications
    --- Also add this ("<script src ="~/lib/jquery/dist/jquery.min.js"></script>") to individual notifications

# ----------------------------------------------------------Build Category Page---------------------------------------------------------------------->
#### Step 25: Create A new model class named "Product" and update with required properties

#### Step 26: Add table and book list in "ApplicationDbContext"

#### Step 27: Open Nuget Package Manager Console and write -
    --- add-migration addProductsToDb
    --- update-database
### Questions related to this project
##### What is nullable in C# .net8.0?
    --- Nullable reference types allow you to express whether a particular reference type (like a class or string) is allowed to be null or not, helping to reduce null reference exceptions and improve code quality. 
    --- This feature enables the compiler to perform more thorough analysis of your code's nullability and provide warnings when potential null references are detected.

##### What wwwroot contains in c# MVC?
    --- The wwwroot folder is a special directory that is used to store static files that are directly served to clients over HTTP. These files include things like HTML, CSS, JavaScript, images, fonts, and other assets that the web browser can request directly. 
    --- The wwwroot folder is designed to be publicly accessible and is a common location for storing resources that make up the user interface and front-end of the web application.

##### What appsettings.json contains in c# MVC?
    --- appsettings.json file is commonly used to store configuration settings that are used by the application. 
    --- These settings can include various parameters, connection strings, API keys, and other configuration values that affect the behavior of the application.

##### Things to keep in mind:
    --- Model is not always needed.
##### What program.cs contains in MVC?
    --- Program.cs file contains the entry point of your application. 
    --- It's the starting point where the application is configured and executed. 
    --- The contents of Program.cs can vary depending on the version of .NET you're using and the specific configuration of your application.
    --- CreateHostBuilder method sets up the configuration and initializes the web host.
    --- UseStartup<Startup>() specifies the Startup class that configures the services and middleware for the application.
    --- app.Environment.IsDevelopment() checks whether the application is running in development mode.
    --- app.UseExceptionHandler("/Home/Error"); adds exception handling middleware to catch and handle exceptions that occur during request processing. If the application is not in development mode, it redirects to the "Error" action of the "Home" controller.
    --- app.UseHsts(); adds HTTP Strict Transport Security (HSTS) middleware to enforce secure connections.
    --- app.UseHttpsRedirection(); adds middleware to redirect HTTP requests to HTTPS.
    --- app.UseStaticFiles(); adds middleware to serve static files (like CSS, JavaScript, images) directly to clients.
    --- app.UseRouting(); adds routing middleware to determine which controller and action should handle the incoming request.
    --- app.UseAuthorization(); adds middleware for authorization, allowing you to restrict access to certain parts of the application based on user roles or policies.
    --- app.MapControllerRoute(...); configures a default controller route. It maps URL patterns to controller actions. In this case, the default route maps to the "Index" action of the "Home" controller.
    --- app.Run(); This line starts the application and listens for incoming HTTP requests. The application will continue running until it's explicitly stopped.

##### What is the default routing pattern in MVC?
    ---- host/{controller}/{action}/{id}
    --- Example: 12.01.53/category/index/3
