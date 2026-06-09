using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Ternary
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string? numStr = Console.ReadLine();

            if(int.TryParse(numStr, out int result))
            {
                Console.WriteLine(result % 2 == 0 ? $"{result} is Even number" : $"{result} is Odd number");
            }
            else
            {
                Console.WriteLine("Please enter the valid number ");
            }
        }
    }
}
