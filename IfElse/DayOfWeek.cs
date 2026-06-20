using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class DayOfWeek
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number : ");
            string strDay = Console.ReadLine();

            if(int.TryParse(strDay, out int day))
            {
                if(day == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if(day == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (day == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (day == 4)
                {
                    Console.WriteLine("Thusday");
                }
                else if (day == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (day == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else if (day == 7)
                {
                    Console.WriteLine("Sunday");
                }
                else
                {
                    Console.WriteLine("Invalid Day");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
