using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class AverageMethod
    {
        static void Main(string[] args)
        {

            // Example - 1
            long?[] longs = { null, 10007L, 37L, 399846234235L };

            double? average = longs.Average();

            Console.WriteLine($"The average is {average}.");


            // Example - 2
            List<int> grades = new List<int> { 78, 92, 100, 37, 81 };
            double avg = grades.Average();

            Console.WriteLine($"Grade Average : {avg}");


            // Example - 3

            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            double fruitAverage = fruits.Average(x => x.Length);
            Console.WriteLine($"Fruit Average : {fruitAverage}");

            // Example - 4
            string[] numbers = { "10007", "37", "299846234235" };

            var aavvgg = numbers.Average(num => long.Parse(num));

            Console.WriteLine($"Long Average Num : {aavvgg}");
        }
    }
}
