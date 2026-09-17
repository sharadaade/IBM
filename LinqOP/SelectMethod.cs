using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SelectMethod
    {
        static void Main(string[] args)
        {
            // Ex - 1
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            var query = fruits.Select((fruit, index) =>
                                  new { index, str = fruit.Substring(0, index) });

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }


            // Ex - 2
            IEnumerable<int> squares = Enumerable.Range(1, 10)
                                                 .Select(x => x * x);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }
    }
}
