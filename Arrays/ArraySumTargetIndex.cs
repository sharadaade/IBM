using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Arrays
{
    internal class ArraySumTargetIndex
    {
        static void Main(string[] args)
        {
            //Input:
            int[] ar = { 2, 7, 11, 15 };
            int target = 9;
            
            //Target = 9

            //Output: 2 + 7 = 9
            //Indices: 0 and 1

            for(int i = 0; i < ar.Length; i++)
            {
                for(int j = 0; j < ar.Length; j++)
                {
                    if (ar[i] + ar[j] == target)
                    {
                        Console.WriteLine($"Target index : {i} {j}");
                    }
                }
            }
        }
    }
}
