using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class LastOrEmptyMethod
    {
        static void Main(string[] args)
        {
            string[] fruits = { "mango", "apple", "jackfruit" };

            string? last = fruits.LastOrDefault();

            Console.WriteLine(String.IsNullOrEmpty(last) ? "String is null" : last);
        }
    }
}
