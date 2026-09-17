using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class TakeMethod
    {
        static void Main(string[] args)
        {
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            IEnumerable<int> topThreeGrades = grades.OrderByDescending(grade => grade).Take(3);

        }
    }
}
