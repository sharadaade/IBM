using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class EmptyMethod
    {
        static void Main(string[] args)
        {
            string[] names1 = { "Hartono, Tommy" };

            string[] names2 = { "Adams, Terry", "Andersen, Henriette Thaulow",
                                "Hedlund, Magnus", "Ito, Shu" };

            string[] names3 = { "Solanki, Ajay", "Hoeing, Helge",
                                "Andersen, Henriette Thaulow",
                                "Potra, Cristina", "Iallo, Lucio" };

            List<string[]> namesList = new List<string[]> { names1, names2, names3 };

            IEnumerable<string> allNames = namesList.Aggregate(Enumerable.Empty<string>(),
                                           (current, next) => next.Length > 3 ? current.Union(next) : current);

            foreach (string name in allNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
