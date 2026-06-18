using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.StringOP
{
    internal class RevStringWithStringBuidler
    {
        static void Main(string[] args)
        {
            string str = "Hello"; // string is immutable

            // StringBuilder instance => it is mutable
            StringBuilder rev = new StringBuilder();

            //      4                   -1 >= 0
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev.Append(str[i]); // olleH
            }
            Console.WriteLine(rev);
        }
    }
}
