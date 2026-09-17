using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class Test
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 10, 60, 40, 70, 70, 20, 30, 80, 80, 50, 90, 100 };

            var result = nums.Where(n => n > 20)
                             .OrderBy(n => n)
                             .Distinct()
                             .Skip(2)
                             .Take(5);
        }
    }
}
