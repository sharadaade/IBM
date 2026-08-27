using IBM.Arrays;
using IBM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SalarySorting
    {
        public static void Main()
        {
            var employees = DataList.GetEmployees();

            var SortedSalary = employees.Select(e => e.Salary)
                                        .OrderBy(s => s);

            foreach(int i in SortedSalary)
                Console.WriteLine(i + " ");
        }
    }
}
