using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class DayConvert
    {
        static void Main(string[] args)
        {
            // Enter days: 373
            // Output => 373 days = 1 year/s, 1 week/s and 1 day/s

            ConvertDay d = new ConvertDay();
            d.Day(373);

        }
    }

    internal class ConvertDay
    {
        public void Day(int days)
        {
            int years = days / 365;          // Ignoring leap year
            int weeks = (days % 365) / 7;
            int remainingDays = days % 365 % 7;

            Console.WriteLine($"{days} days = {years} year/s, {weeks} week/s and {remainingDays} day/s");

        }
    }
}
