using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Arrays
{
    internal class ArrayRemoveDuplicateElement
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 3, 3, 4, 5, 6, 4};
            List<int> nAr = new List<int>();
            //int[] nAr = new int[5];
            //int k = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                int count = 0;
               
                for (int j = 0; j < ar.Length; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    nAr.Add(ar[i]);
                    //k++;
                }
            }
            foreach(int i in nAr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
