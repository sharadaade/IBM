using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Ternary
{
    internal class MaxTwoNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter the 2nd number : ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine(first > second ? $"Max is {first}" : $"Max is {second}");
        }
    }
}
