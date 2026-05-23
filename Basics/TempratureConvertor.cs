using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class TempratureConvertor
    {
        public int Convert(int cel)
        {
            return ((cel * 9 / 5) + 32);
        }
        static void Main(string[] args)
        {
            int num;
            string input;

            Console.Write("Please enter temprature in celcius : ");
            input = Console.ReadLine();

            if(int.TryParse(input, out num))
            {
                TempratureConvertor obj = new TempratureConvertor();
                int Fahrenheit = obj.Convert(num);
                Console.Write("Temprature in Fahrenheit : " + Fahrenheit);
            }
            else
            {
                Console.WriteLine("Please enter the valid input.");
            }
        }
    }
}
