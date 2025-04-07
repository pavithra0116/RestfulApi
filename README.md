# Creating & Consuming RESTful API's in .NET Core
---------------------------------------------------

# Step 1 : Create the API

* 1.1 : Create a New Web API Project

--> dotnet new webapi -n RestfulApi

* 1.2 : Define the Model

--> Create a Models/Product.cs file

* 1.3 : Configure Database with EF Core

* 1.3.1 : Install Entity Framework Core - Add the below packages

--> dotnet add package Pomelo.EntityFrameworkCore.MySql --version 9.0.3
--> dotnet add package Microsoft.EntityFrameworkCore.Tools

* 1.3.2 : Create a Database Context

--> Create Data/ApplicationDbContext.cs

* 1.4 : Add Database Connection in appsettings.json file

"ConnectionStrings": {
    "DefaultConnection": "Server=localhost; Database=MyApiDb; User=root@localhost; Password=root;TrustServerCertificate=True"
}


* 1.5 : Modify Program.cs to Configure Database

* 1.6 : Create a Controller(ProductsController.cs)

* 1.7 : Run Database Migration

--> dotnet tool install --global dotnet-ef
--> dotnet ef migrations add InitialCore
--> dotnet ef database update

