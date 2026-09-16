using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class DefaultIfEmpty
    {
        static void Main(string[] args)
        {
            List<Pet> pets =
                            new List<Pet>{ new Pet { Name="Barley", Age=8 },
                                           new Pet { Name="Boots", Age=4 },
                                           new Pet { Name="Whiskers", Age=1 } };

            foreach (Pet pet in pets.DefaultIfEmpty())
            {
                Console.WriteLine(pet.Name);
            }
        }
    }
}
