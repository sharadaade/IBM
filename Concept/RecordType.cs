using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Concept
{
    //1. Declare the record using positional syntax(immutable by default)
    public record Product(string Name, decimal Price, string Category);
    internal class RecordType
    {
        static void Main(string[] args)
        {
            // 2. Instantiate records
            var product1 = new Product("Laptop", 999.99m, "Electronics");
            var product2 = new Product("Laptop", 999.99m, "Electronics");
            var product3 = new Product("Smartphone", 599.99m, "Electronics");

            // 3. Built-in ToString() formatting (outputs data instead of type name)
            Console.WriteLine($"Product 1: {product1}");
            // Output: Product 1: Product { Name = Laptop, Price = 999.99, Category = Electronics }

            // 4. Value-Based Equality Check (==)
            // True because the data matches, even though they are different objects in memory
            Console.WriteLine($"Is product1 == product2? {product1 == product2}"); // Output: True
            Console.WriteLine($"Is product1 == product3? {product1 == product3}"); // Output: False

            // 5. Immutability (Uncommenting this line throws a compilation error)
            // product1.Price = 899.99m; 

            // 6. Non-Destructive Mutation using the 'with' expression
            // Creates a new instance with selective modifications while keeping product1 unchanged
            var discountedProduct = product1 with { Price = 899.99m };

            Console.WriteLine($"Original: {product1.Price}");   // Output: 999.99
            Console.WriteLine($"Discounted: {discountedProduct.Price}"); // Output: 899.99

        }
    }
}
