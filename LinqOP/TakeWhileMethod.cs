using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class TakeWhileMethod
    {
        static void Main(string[] args)
        {

            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            IEnumerable<string> query = fruits.TakeWhile(fruit => String.Compare("orange", fruit, true) != 0);

        }
    }
}
