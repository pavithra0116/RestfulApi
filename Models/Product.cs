// Step 1.2 - Define the Model

using System.ComponentModel.DataAnnotations;

namespace RestfulApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)] // Required attribute specifies that this field must have a value - it cannot be NULL
        public required string Name { get; set; }

        [Range(0.01, 9999.99)] // Range attribute enforces that the price must be beween 0.01 and 9999.99
        public decimal Price { get; set; }
    }
}


/* PRODUCT class captures essential information about a product, including 
its ID, name and price, while also enforcing VALIDATION rules through DATA ANNOTATIONS */