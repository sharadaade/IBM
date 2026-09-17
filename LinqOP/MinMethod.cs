using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class MinMethod
    {
        static void Main(string[] args)
        {
            int?[] grades = { 78, 92, null, 99, 37, 81 };

            int? min = grades.Min();

            Console.WriteLine("The lowest grade is {0}.", min);



            double[] doubles = { 1.5E+104, 9E+103, -2E+103 };

            double min2 = doubles.Min();

            Console.WriteLine("The smallest number is {0}.", min);


            var p = new List<Pet>(){ 
                                        new Pet { Name="Barley", Age=8 },
                                        new Pet { Name="Boots", Age=4 },
                                        new Pet { Name="Whiskers", Age=1 } 
                                   };

            int minAge = p.Min(pet => pet.Age);
        }
    }
}
