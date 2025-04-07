// Step 1.6 : Create a Controller(ProductsController.cs)

//Required Namespaces

using Microsoft.AspNetCore.Mvc; // Imports ASP .NET Core MVC features
using RestfulApi.Data; // Access to the Data Context
using RestfulApi.Models; // Access to the Product model
using System.Collections.Generic; // For using lists and collections
using System.Linq; // For LINQ queries

namespace RestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        private readonly ProductDbContext _context;

        //constructor initialization

        public ProductsController(ProductDbContext context)
        {
            _context = context;
            Console.WriteLine(_context);
        }

        // GET : api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_context.Products.ToList());
        }

        // GET : api/products/1
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _context.Products.Find(id);
            return product == null ? NotFound() : Ok(product);
        }

        // POST : api/products
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        // PUT : api/products/1
        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Product product)
        {
            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null) return NotFound();

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            _context.SaveChanges();

            return NoContent();

        }

        // DELETE : api/products/1
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}