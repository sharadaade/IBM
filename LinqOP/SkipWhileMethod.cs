using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SkipWhileMethod
    {
        static void Main(string[] args)
        {
            int[] grades = { 10, 30, 20, 50, 40, 90, 100 };

            IEnumerable<int> lowerGrades = grades
                                           .OrderByDescending(grade => grade)
                                           .SkipWhile(grade => grade >= 80);

            Console.WriteLine("All grades below 80:");

            foreach (int grade in lowerGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
