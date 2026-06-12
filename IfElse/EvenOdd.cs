using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string? strNum = Console.ReadLine();

            if(int.TryParse(strNum, out int result))
            {
                if(result % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
