using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class WhereMethod
    {
        static void Main(string[] args)
        {
            // Filters a sequence of values based on a predicate.
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango",
                                                     "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();

            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };

            IEnumerable<int> query1 = numbers.Where((number, index) => number <= index * 10);

            foreach (int number in query1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
