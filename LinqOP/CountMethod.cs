using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    class Peti
    {
        public string Name { get; set; }
        public bool Vaccinated { get; set; }
    }
    internal class CountMethod
    {
        static void Main(string[] args)
        {
            // Example -  1
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape", "Berry" };

            try
            {
                int numberOfFruits = fruits.Count();

                Console.WriteLine($"There are {numberOfFruits} fruits in the collection.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }


            // Example - 2 
            Peti[] pets = { new Peti { Name = "Barley", Vaccinated = true },
                            new Peti { Name = "Boots", Vaccinated = false },
                            new Peti { Name = "Whiskers", Vaccinated = false }
                          };

            int vaccinetedCount = pets.Count(p => p.Vaccinated);

            int nonVaccinetedCount = pets.Count(p => !p.Vaccinated);

            Console.WriteLine("Vaccineted : " + vaccinetedCount);
            Console.WriteLine("Non-Vaccineted : " + nonVaccinetedCount);


            // Example - 3
            List<int> nums = new List<int>() {1, 4, 55, 44, 64, 65, 75, 90 };
            int numCount = nums.Count(x => x > 20);

            Console.WriteLine($"Num count : {numCount}");

        }
    }
}
