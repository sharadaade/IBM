using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class LengthConvertor
    {
        public void Converter(decimal input)
        {
            Console.WriteLine($"Length in : { input / 100:F4} m");
            Console.WriteLine($"Length in : {input/ 100000:F4} Km");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the length in CM : ");
            decimal input = Convert.ToDecimal(Console.ReadLine());

            LengthConvertor obj = new LengthConvertor();
            obj.Converter(input);
        }
    }
}
