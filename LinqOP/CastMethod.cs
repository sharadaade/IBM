using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class CastMethod
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            //Console.WriteLine($"{fruits[0].GetType()}");

            IEnumerable<String> query = fruits.Cast<string>()
                                              .OrderBy(fruits => fruits)
                                              .Select(fruits => fruits);

            foreach(string item in query)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
