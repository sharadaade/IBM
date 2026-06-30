using IBM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SumAndAvgSalary
    {
        static void Main(string[] args)
        {
            var employees = DataList.GetEmployees();

            // Sum of all employees salary
            var SumOfSalary = employees.Sum(x => x.Salary);
            Console.WriteLine($"Sum of salary : {SumOfSalary}$");

            Console.WriteLine();

            var AverageSalary = employees.Average(x => x.Salary);
            Console.WriteLine($"Average Salary : {AverageSalary}$");

        }
    }
}
