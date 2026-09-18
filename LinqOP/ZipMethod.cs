using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ZipMethod
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            foreach (var item in numbersAndWords)
            {
                //Console.WriteLine(item);
            }

            // This code produces the following output:

            // 1 one
            // 2 two
            // 3 three


            // Array storing the names of the months
            string[] months = { "January", "February", "March", "April", "May", 
                                "June", "July", "August", "September", "October", "November", "December" };

            // Array storing the corresponding month numbers
            int[] monthNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 , 13, 14};

            var monthly = months.Zip(monthNumbers, (m, n) => n + " " + m);

            foreach (var item in monthly)
            {
                Console.WriteLine(item);
            }
        }
    }
}
