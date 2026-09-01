using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year : ");
            string? strYear = Console.ReadLine();

            if(int.TryParse(strYear, out int year))
            {
                if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("LEAP YEAR");
                }
                else
                {
                    Console.WriteLine("COMMON YEAR");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
