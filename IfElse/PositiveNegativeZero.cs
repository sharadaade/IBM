using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string strNum = Console.ReadLine();

            if(int.TryParse(strNum, out int result))
            {
                PositiveNegativeZero obj = new PositiveNegativeZero();
                obj.Check(result);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public void Check(int num)
        {
            if(num > 0)
                Console.WriteLine("Positive Number");
            else if(num < 0)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine("Number is Zero");
        }
    }
}
