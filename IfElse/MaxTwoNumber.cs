using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class MaxTwoNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int second = Convert.ToInt32(Console.ReadLine());

            if(first > second)
            {
                Console.WriteLine($"Max number is : {first}");
            }
            else
            {
                Console.WriteLine($"Max number is : {second}");
            }
        }
    }
}
