using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ThenByMethod
    {
        static void Main(string[] args)
        {
            string[] fruits = { "grape", "passionfruit", "banana", "mango",
                                "orange", "raspberry", "apple", "blueberry" };

            // Sort the strings first by their length and then
            // alphabetically by passing the identity selector function.

            IEnumerable<string> query = fruits.OrderBy(fruit => fruit.Length)
                                              .ThenBy(fruit => fruit);

        }
    }
}
