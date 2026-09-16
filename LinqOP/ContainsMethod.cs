using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ContainsMethod
    {
        static void Main(string[] args)
        {
            // Example - 1
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            string fruit = "mango";

            bool hasFuit = fruits.Contains(fruit);

            Console.WriteLine(hasFuit ? "does" : "does not");

        }
    }
}
