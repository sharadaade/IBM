using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IBM.Ternary
{
    internal class CheckAlphabets
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            string result = (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z') ? "Alphabate" : "NOT Aphabate";

            Console.WriteLine(result);
        }
    }
}
