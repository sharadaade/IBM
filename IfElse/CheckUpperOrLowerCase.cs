using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class CheckUpperOrLowerCase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter character to check Uppercase or Lowercase :  ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("lowercase");
            }
            else if(ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("UPPERCASE");
            }
            else
            {
                Console.WriteLine("Not an alphabet character");
            }
        }
    }
}
