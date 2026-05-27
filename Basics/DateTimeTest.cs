using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class DateTimeTest
    {
        static void Main(string[] args)
        {
            var timeOnly = DateTime.Now.ToString("HH:MMtt");
            Console.WriteLine(timeOnly);

            var dateOnly = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateOnly);

            var dayOnly = DateTime.Now.ToString("dddd");
            Console.WriteLine(dayOnly);

            var monthOnlyName = DateTime.Now.ToString("MMM");
            Console.WriteLine(monthOnlyName);
        }
    }
}
