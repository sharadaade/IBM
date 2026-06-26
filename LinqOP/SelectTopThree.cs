using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SelectTopThree
    {
        static void Main(string[] args)
        {
            int[] ar = { 8, 2, 4, 1, 3, 7, 6, 5 };

            var topThree = ar.Select(x => x)
                             .Take(3);

            foreach(int i in topThree)
                Console.Write(i + " ");
                             
        }
    }
}
