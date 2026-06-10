using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class CheckDivisibility
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string? strNum = Console.ReadLine();

            if(int.TryParse(strNum, out int result))
            {
                CheckDivisibility obj = new CheckDivisibility();
                obj.Check(result);
            }
            else
            {
                Console.WriteLine("Please enter the valid input");
            }
        }
        public void Check(int num)
        {
            if(num % 5 == 0 && num % 11 ==0)
            {
                Console.WriteLine("Number is divisible by 5 and 11");
            }
            else if(num % 5 == 0)
            {
                Console.WriteLine("Number is divisible by 5");
            }
            else if(num % 11 == 0)
            {
                Console.WriteLine("Number is divisible by 11");
            }
        }
    }
}
