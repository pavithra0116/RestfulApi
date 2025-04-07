// Step 1.3 - Create a Database Context

using Microsoft.EntityFrameworkCore;
using RestfulApi.Models; // This imports the models, likely the PRODUCT class

namespace RestfulApi.Data
{
    /* Inherited from DbContext 
    DbContext is a fundamental class in Entity Framework Core, that enables interaction with a Database */
    public class ProductDbContext : DbContext
    {
        //constructor initialization

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}


/* This code defines a database context class, ApplicationDbContext, 
which is part of the data layer of an ASP.NET Core application.

It contains a DbSet for Product, allowing CRUD operations on the Product 
objects int the associated database.*/