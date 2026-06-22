using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class PrintYesterDayDate
    {
        static void Main(string[] args)
        {
            
            DateTime Today = DateTime.Today;

            DateTime YesterDay = DateTime.Today.AddDays(-1);

            Console.WriteLine(Today);
            Console.WriteLine(YesterDay);

        }
    }
}
