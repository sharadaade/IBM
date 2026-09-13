using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class AnyMethod
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5};

            bool isNumberPresent = nums.Any();

            Console.WriteLine(isNumberPresent ? "Number Present" : "Number is Unavailable");

        }
    }
}
