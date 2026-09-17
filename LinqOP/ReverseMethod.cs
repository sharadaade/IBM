using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ReverseMethod
    {
        static void Main(string[] args)
        {
            char[] apple = { 'a', 'p', 'p', 'l', 'e' };

            char[] reversed = apple.Reverse().ToArray();

            foreach (char chr in reversed)
            {
                Console.Write(chr + " ");
            }
            Console.WriteLine();
        }
    }
}
