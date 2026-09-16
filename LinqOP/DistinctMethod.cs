using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
    internal class DistinctMethod
    {
        static void Main(string[] args)
        {

            // Example - 1
            //Product[] products = { new Product { Name = "apple", Code = 9 },
            //           new Product { Name = "orange", Code = 4 },
            //           new Product { Name = "apple", Code = 9 },
            //           new Product { Name = "lemon", Code = 12 } };

            // Exclude duplicates.

            //IEnumerable<Product> noduplicates = products.Distinct();

            //foreach (var product in noduplicates)
            //    Console.WriteLine(product.Name + " " + product.Code);


            //Example - 2 
            List<int> ages = new List<int>() { 21, 46, 46, 55, 17, 21, 55, 55 };

            IEnumerable<int> distinctAge = ages.Distinct();



        }
    }
}
