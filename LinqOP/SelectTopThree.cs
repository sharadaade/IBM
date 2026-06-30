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

            // Select TOP Three
            var topThree = ar.OrderByDescending(x => x)
                             .Take(3);

            
            Console.WriteLine("Top Three : ");
            foreach(int i in topThree)
                Console.Write(i + " ");

            // Select Min Three
            var minThree = ar.OrderBy(x => x)
                           .Take(3);

            Console.WriteLine("\nMin Three : ");
            foreach(int i in minThree)
            {
                Console.Write(i + " ");
            }

            var listAscending = ar.OrderBy( m => m);
            
        }
    }
}
