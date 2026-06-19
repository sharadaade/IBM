using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.IfElse
{
    internal class VowelConsonant
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character : ");
            char ch = Console.ReadKey().KeyChar;
            
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
