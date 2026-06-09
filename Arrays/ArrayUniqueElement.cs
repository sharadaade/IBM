using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Arrays
{
    internal class ArrayUniqueElement
    {
        static void Main(string[] args)
        {
            int[] ar = { 2, 3, 3, 4, 5, 6, 6 };

            for(int i = 0; i < ar.Length; i++)
            {
                int count = 0;
                for(int j = 0; j < ar.Length; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }
                }
                if(count == 1)
                {
                    Console.Write(ar[i] + " ");
                }
            }
        }
    }
}
