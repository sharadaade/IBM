using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class PowerOfNumber
    {
        public int NumberPower(int num, int pow)
        {
            int result = 1;
            for(int i = 1; i <= pow; i++)
            {
                result = result * num;
            }
            return result;
        }
        static void Main(string[] args)
        {
            PowerOfNumber obj = new PowerOfNumber();
            int result = obj.NumberPower(5, 3);
            Console.WriteLine(result);
        }
        
    }
}
