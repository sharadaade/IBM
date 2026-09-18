using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class UnionByMethod
    {
        static void Main(string[] args)
        {
            (int ProductId, string Name, decimal Price)[] localProducts =   {
                                                                                (101, "Laptop", 1000m),
                                                                                (102, "Mouse", 100m),
                                                                                (103, "Keyboard", 120m)
                                                                            };

            (int ProductId, string Name, decimal Price)[] warehouseProducts = {
                                                                                   (102, "Mouse", 100m),  // Duplicate ProductId (already in local)
                                                                                   (104, "Monitor", 800m),
                                                                                   (101, "Laptop", 1000m) // Duplicate ProductId (already in local)
                                                                              };

            var combinedProducts = localProducts.UnionBy( warehouseProducts,
                                                          product => product.ProductId);

            foreach (var product in combinedProducts)
            {
                Console.WriteLine($"{product.ProductId}: {product.Name} - ${product.Price}");
            }
        }
    }
}
