using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class IntersectMethod
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 3, 5, 6, 7 };

            // Find common elements
            // Used to find the common elements between two sequences (collections)
            IEnumerable<int> common = list1.Intersect(list2);


            Console.WriteLine("Common number are : ");
            foreach(int i in common)
                Console.WriteLine(i);
        }
    }
}
