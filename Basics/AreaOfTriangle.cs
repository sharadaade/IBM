using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the base : ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the height : ");
            //double h = Convert.ToDouble(Console.ReadLine());

            //double result = 0.5 * b * h;

            //Console.WriteLine($"Area of triangle is : {result}");

            Console.Write("Enter the base : ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the height : ");
            decimal h = Convert.ToDecimal(Console.ReadLine());

            decimal result = 0.5m * b * h;

            Console.WriteLine($"Area of triangle is : {result}");
        }
    }
}
