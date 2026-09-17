using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SingleMethod
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            string fruit1 = fruits.Single(fruit => fruit.Length > 10);

            Console.WriteLine(fruit1);
        }
    }
}
