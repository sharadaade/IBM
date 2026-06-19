using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class CheckAlphabets
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;


            if((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine($"{ch} is an alphabet.");
            }
            else
            {
                Console.WriteLine($"{ch} is not an alphabet.");
            }
        }
    }
}
