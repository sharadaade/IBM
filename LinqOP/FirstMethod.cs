using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class FirstMethod
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                              83, 23, 87, 435, 67, 12, 19 };

            // Returns the first element of a sequence.
            // NOTE - If there is no element then it shows Unhandled Exception

            int first = numbers.First();

            Console.WriteLine(first);

            /*
             This code produces the following output:

             9
            */
        }
    }
}
