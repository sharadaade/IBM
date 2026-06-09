using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string? strNumber = Console.ReadLine();

            if(int.TryParse(strNumber, out int newNumber))
            {
                if(newNumber % 2 == 0)
                {
                    Console.WriteLine("The number is Even");
                }
                else
                {
                    Console.WriteLine("The number is Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input please enter the valid number");
            }

            //Console.WriteLine(newNumber);
        }
    }
}
