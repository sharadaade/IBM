using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class MaxThreeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int third = Convert.ToInt32(Console.ReadLine());

            if(first > second && first > third)
            {
                Console.WriteLine($"Max number is : {first}");
            }
            else if(second > third)
            {
                Console.WriteLine($"Max number is : {second}");
            }
            else
            {
                Console.WriteLine($"Max number is : {third}");
            }
        }
    }
}
