using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ExceptMethod
    {
        static void Main(string[] args)
        {
            double[] numbers1 = { 2.0, 2.0, 2.1, 2.2, 2.3, 2.3, 2.4, 2.5 };
            double[] numbers2 = { 2.2 , 2};


            // It print the all from the numbers1 except numbers2
            IEnumerable<double> onlyInFirstSet = numbers1.Except(numbers2);

            foreach (double number in onlyInFirstSet)
                Console.WriteLine(number);
        }
    }
}
