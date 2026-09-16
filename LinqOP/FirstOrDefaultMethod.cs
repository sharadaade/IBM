using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class FirstOrDefaultMethod
    {
        static void Main(string[] args)
        {
            //Returns the first element of a sequence, or a default value if no element is found.

            string[] names = { "Hartono, Tommy", "Adams, Terry",
                     "Andersen, Henriette Thaulow",
                     "Hedlund, Magnus", "Ito, Shu" };

            string firstLongName = names.FirstOrDefault(name => name.Length > 20);

            Console.WriteLine($"The first long name is {firstLongName}.");

            string firstVeryLongName = names.FirstOrDefault(name => name.Length > 30);

            Console.WriteLine("There is {0} name longer than 30 characters.", string.IsNullOrEmpty(firstVeryLongName) ? "not a" : "a");

            Console.WriteLine(names.FirstOrDefault());

        }
    }
}
