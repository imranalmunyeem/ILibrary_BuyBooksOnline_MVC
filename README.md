# ILibrary_BuyBooksOnline

## Tools used in this project
    --- C#, .net 8.0
    --- Visual Studio Preview 

## Features of this project 
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

### Step 1: Create A new MVC project
    --- File -> New -> Project -> MVC -> Create

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
