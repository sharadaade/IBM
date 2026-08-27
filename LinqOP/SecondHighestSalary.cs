using IBM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SecondHighestSalary
    {
        static void Main(string[] args)
        {
            var employees = DataList.GetEmployees();

            var seconHighSalary = employees.Select(x => x.Salary)
                                           .Distinct()
                                           .OrderByDescending(sal => sal)
                                           .Skip(1)
                                           .FirstOrDefault();  

            Console.WriteLine(seconHighSalary);

            // After using OrderBy() or OrderByDescending() orginal unchanged

            Console.WriteLine("Original : ");
            foreach(var i in employees)
            {
                Console.WriteLine(i.Salary + " ");
            }
        }
    }
}
