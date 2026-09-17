using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class RepeatMethod
    {
        static void Main(string[] args)
        {
            IEnumerable<string> strings = Enumerable.Repeat($"I like programming.", 15);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
