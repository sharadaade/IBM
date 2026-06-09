using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class SwapTwoNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the a value : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the b value : ");
            int b = Convert.ToInt32(Console.ReadLine());

            SwapTwoNumber obj = new SwapTwoNumber();

            obj.SwapWithTwoVariable(a, b);
            obj.SwapWithouTwoVariable(a, b);

        }

        public void SwapWithTwoVariable(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Value of a : {a} \nValue of b : {b}");
        }

        public void SwapWithouTwoVariable(int a, int b)
        {
            // Tuple
            (a, b) = (b, a);
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
