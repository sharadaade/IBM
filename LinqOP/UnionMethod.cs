using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IBM.LinqOP
{
    internal class UnionMethod
    {
        static void Main(string[] args)
        {
            // Ex - 1
            int[] ints1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
            int[] ints2 = { 8, 3, 6, 4, 4, 9, 1, 0 };

            // Used to combine two sequences into a single sequence containing only unique elements
            IEnumerable<int> union = ints1.Union(ints2);

            foreach (int num in union)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();

            // Ex - 2
            string[] one = { "one", "two", };
            string[] two = { "two", "one" };
            IEnumerable<string> final = one.Union(two);

            foreach(string item in final)
                Console.WriteLine($"{item}");

        }
    }
}
