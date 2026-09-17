using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IBM.LinqOP
{
    internal class OrderByMethod
    {
        static void Main(string[] args)
        {
            // Sorts the elements of a sequence in ascending order.

            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                           new Pet { Name="Boots", Age=4 },
                           new Pet { Name="Whiskers", Age=1 } };

            IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

            foreach (Pet pet in query)
            {
                Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
            }
        }
    }
}
