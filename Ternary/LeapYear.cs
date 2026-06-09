using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Ternary
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string numStr = Console.ReadLine();

            if(int.TryParse(numStr, out int year))
            {
                // === Normal ===
                //if(year % 4 == 0 && year % 100 == 0)
                //{
                //    Console.WriteLine("Leap Year");
                //}
                //else if(year % 400 == 0)
                //{
                //    Console.WriteLine("Leap Year");
                //}
                //else
                //{
                //    Console.WriteLine("Normal Year");
                //}

                // === With Ternary Operator ===

                string result = (year % 4 == 0 && year % 100 == 0) ? "Leap Lear" : (year % 400 == 0) ? "Leap Year" : "Normal Year";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
