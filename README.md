#ASP.NET CORE

In this sprint, you'll take a close look at how to build a REST-API with the ASP.NET Core framework.You can write ASP.NET Core applications in a number of languages (C#, Visual Basic, F#). C# is the most popular choice, and it's what you'll use in this sprint . You can build and run ASP.NET Core applications on Windows, Mac, and Linux.


What's in this repo
In this repo you have :
The Program.cs and Startup.cs files set up the web server and ASP.NET Core pipeline. The Startup class is where you can add middleware that handles and modifies incoming requests, and serves things like static content or error pages. It's also where you add your own services to the dependency injection container.
The Models,  and Controllers directories contain the components of the Model-View-Controller (MVC) architecture.
The wwwroot directory contains static assets like CSS, JavaScript, and image files. Files in wwwroot will be served as static content, and can be bundled and minified automatically. 
The appsettings.json file contains configuration settings ASP.NET Core will load on startup. You can use this to store database connection strings or other things that you don't want to hard-code.


Bare Minimum Requirements
Installation: 
Before you can start learning how to use ASP.NET CORE,make sure you have the .NET Core SDK installed on your machine. 
After you make sure everything is installed ,after entering  ASP.NET CORE
directory run the server by:
dotnet run

Hello World in C#

Before you dive into ASP.NET Core, try creating and running a simple C# application.
In Program.cs file write line of code in c# to print “Hello World in c#” on terminal. Run dotnet run  after that.
Note that you need to use postman to check the routes output.
Postman is an application for testing APIs, by sending request to the web server and getting the response back.


In Models/Cat.cs file, Inside of there, we created a new class called Cat. add a property called Name to that class. Of course, you can add more properties to your cat, if you want to.


In Controllers/CatController.cs file, write the required code to handle POST request to "api/cat" route, this request should add cat to cats List.


In Controllers/CatController.cs file, write the required code to handle GET request to "api/cat" route, this request should display all cats stored in cats List.


In Controllers/CatController.cs file, write the required code to handle PUT request to "api/cat" route, this request should update an existing element at our endpoint.
In Controllers/CatController.cs file, write the required code to handle DELETE request to "api/cat" route, this request should delete an  element at our endpoint.


Advanced Content


Make your ASP.NET CORE  server serve up the static html and js files for the front end  .
Use database to save the data instead of cats List.



