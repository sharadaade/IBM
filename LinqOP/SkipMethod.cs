using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SkipMethod
    {
        static void Main(string[] args)
        {
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            Console.WriteLine("All grades except the first three:");
            foreach (int grade in grades.Skip(3))
            {
                Console.WriteLine(grade);
            }
        }
    }
}
