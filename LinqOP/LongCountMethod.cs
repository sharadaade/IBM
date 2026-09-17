using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    class Ani
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class LongCountMethod
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            long count = fruits.LongCount();

            // NOTE - Use this method rather than Count when you expect the result to be greater than MaxValue.

            Console.WriteLine("There are {0} fruits in the collection.", count);

            Console.WriteLine();

            Ani[] pets = { new Ani { Name="Barley", Age=8 },
                           new Ani { Name="Boots", Age=4 },
                           new Ani { Name="Whiskers", Age=1 } 
                         };

            const int Age = 3;

            long countPet = pets.LongCount(pet => pet.Age > Age);

            Console.WriteLine($"There are {countPet} animals over age {Age}");
        }
    }
}
