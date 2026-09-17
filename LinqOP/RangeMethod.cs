using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class RangeMethod
    {
        static void Main(string[] args)
        {
            // Generates a sequence of integral numbers within a specified range.

            // Generate a sequence of integers from 1 to 10
            // and then select their squares.
            IEnumerable<int> numbers = Enumerable.Range(1, 10);

            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }
    }
}
