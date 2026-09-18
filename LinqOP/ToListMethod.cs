using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ToListMethod
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            List<int> lengths = fruits.Select(fruit => fruit.Length).ToList();

            foreach (int length in lengths)
            {
                Console.WriteLine(length);
            }

            //Console.WriteLine(lengths.GetType());
        }
    }
}
