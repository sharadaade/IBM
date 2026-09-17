using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class LastMethod
    {
        static void Main(string[] args)
        {
            //IEnumerable<>
            //Returns the last element of a sequence.
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54, 83, 23, 87, 67, 12, 19 };
            List<string> names = new List<string>() { "Sharad",  "Raj", "Kumar", "Aditya" };

            int result = numbers.Last();
            int last = numbers.Last(n => n > 80);
            Console.WriteLine(result);

            string lastName = names.Last();
            string lastNameCheck = names.Last(name => name.Contains("Ad"));
            Console.WriteLine(lastName);
        }
    }
}
