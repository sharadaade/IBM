using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.StringOP
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            char[] ar = str.ToCharArray();

            int start = 0;
            int end = str.Length - 1;

            while(start < end)
            {
                char temp = ar[start];
                ar[start] = ar[end];
                ar[end] = temp;

                start++; end--;
            }

            string reverse = new String(ar);
            Console.WriteLine(reverse);
        }
    }
}
