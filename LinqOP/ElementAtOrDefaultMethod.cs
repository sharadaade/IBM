using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ElementAtOrDefaultMethod
    {
        static void Main(string[] args)
        {
            string[] names = { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow","Hedlund, Magnus", "Ito, Shu" };

            int index = 4;

            string name = names.ElementAtOrDefault(index);


            Console.WriteLine($"The name chosen at index {index} is {name}.", index,
                                String.IsNullOrEmpty(name) ? "<no name at this index>" : name);
        }
    }
}
