using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class MaxMethod
    {
        static void Main(string[] args)
        {

            // Example - 1
            double?[] doubles = { null, 1.5E+104, 9E+103, -2E+103 };

            double? max = doubles.Max();

            Console.WriteLine("The largest number is {0}.", max);


            // Example - 2
            List<long> longs = new List<long> { 4294967296L, 466855135L, 81125L };

            long max1 = longs.Max();

            Console.WriteLine("The largest number is {0}.", max1);


            // Example - 3
            Pet[] pets = {
                            new Pet { Name="Barley", Age=8 },
                            new Pet { Name="Boots", Age=4 },
                            new Pet { Name="Whiskers", Age=1 }
                         };


            int max3 = pets.Max(pet => pet.Age + pet.Name.Length);

            Console.WriteLine("The maximum pet age plus name length is {0}.", max3);

            var add = pets.Max(p => p.Age + p.Name.Length);

        }
    }
}
