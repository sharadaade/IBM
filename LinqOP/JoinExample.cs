using IBM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class JoinExample
    {
        static void Main(string[] args)
        {
            // Data Using from the DataList calss
            List<Employee> employees = DataList.GetEmployees();
            List<Department> departments = DataList.GetDepartments();

            // Method Syntax
            var result = employees.Join(
                                   departments,                  // 1. Who am I joining?
                                   e => e.DepartmentId,          // 2. Key from first collection
                                   d => d.DepartmentId,          // 3. Key from second collection
                                   (e, d) => new                 // 4. What result do I want?
                                   {
                                       EmployeeName = e.Name,
                                       DepartmentName = d.Name
                                   });



            // Query Synatx
            var result2 =   from e in employees
                            join d in departments
                                on e.DepartmentId equals d.DepartmentId
                            select new
                            {
                                EmployeeName = e.Name,
                                DepartmentName = d.Name
                            };

            foreach (var item in result)
                Console.WriteLine($"{item.EmployeeName} : {item.DepartmentName}");




            // LINQ Join()
            // Joins two collections using matching keys, similar to SQL INNER JOIN.
            //
            // Syntax:
            // firstCollection.Join(
            //     secondCollection,
            //     firstKey,
            //     secondKey,
            //     (first, second) => result
            // );
            //
            // Example:
            // employees.Join(
            //     departments,
            //     e => e.DepartmentId,       // Key from Employees
            //     d => d.DepartmentId,       // Key from Departments
            //     (e, d) => new              // Create the result
            //     {
            //         EmployeeName = e.Name,
            //         DepartmentName = d.DepartmentName
            //     }
            // );
            //
            // Remember:
            // 1. First collection
            // 2. Second collection
            // 3. Key from first collection
            // 4. Key from second collection
            // 5. Result to create
            //
            // Join() returns only records where the keys match.
            // Therefore, LINQ Join() works like SQL INNER JOIN.

        }
    }
}
