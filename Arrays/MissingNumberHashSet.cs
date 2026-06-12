using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Arrays
{
    internal class MissingNumberHashSet
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 3, 4, 6, 7, 9, 10 };
            int n = 10;

            Console.Write("Element : ");

            foreach(int i in ar)
            {
                Console.Write(i + " ");
            }


            HashSet<int> set = new HashSet<int>(ar);

            Console.WriteLine();
            Console.Write("Missing Number : ");
            for(int i = 1; i <= n; i++)
            {
                if(!set.Contains(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
