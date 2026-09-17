using IBM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    //public class Employee
    //{
    //    public int EmployeeId { get; set; }
    //    public string Name { get; set; }
    //    public int DepartmentId { get; set; }
    //}

    //public class Department
    //{
    //    public int DepartmentId { get; set; }
    //    public string DepartmentName { get; set; }
    //}


    internal class LeftJoinMethod
    {
        static void Main(string[] args)
        {
            //var employees = new List<Employee>
            //                {
            //                    new Employee
            //                    {
            //                        EmployeeId = 1,
            //                        Name = "Rahul",
            //                        DepartmentId = 10
            //                    },

            //                    new Employee
            //                    {
            //                        EmployeeId = 2,
            //                        Name = "Priya",
            //                        DepartmentId = 20
            //                    },

            //                    new Employee
            //                    {
            //                        EmployeeId = 3,
            //                        Name = "Amit",
            //                        DepartmentId = 30
            //                    }
            //                };


            //var departments = new List<Department>
            //                  {
            //                      new Department
            //                      {
            //                        DepartmentId = 10,
            //                        DepartmentName = "IT"
            //                      },

            //                      new Department
            //                      {
            //                        DepartmentId = 20,
            //                        DepartmentName = "HR"
            //                      }
            //                  };


            //// LEFT JOIN — Method Syntax
            //var result = employees                           // ← LEFT collection
            //                        .GroupJoin( 
            //                            departments,         // ← RIGHT collection
            //                            e => e.DepartmentId,
            //                            d => d.DepartmentId,
            //                            (e, departmentGroup) => new
            //                            {
            //                                Employee = e,
            //                                Departments = departmentGroup
            //                            }
            //                        )
            //                        .SelectMany(
            //                            x => x.Departments.DefaultIfEmpty(),
            //                            (x, d) => new
            //                            {
            //                                EmployeeName = x.Employee.Name,
            //                                DepartmentName = d?.DepartmentName ?? "No Department"
            //                            }
            //                        );

            //// LEFT JOIN — Query Syntax
            //var result1 =   from e in employees             // ← LEFT collection
            //                join d in departments           // ← RIGHT collection
            //                    on e.DepartmentId equals d.DepartmentId
            //                    into departmentGroup

            //                from d in departmentGroup.DefaultIfEmpty()

            //                select new
            //                {
            //                    EmployeeName = e.Name,
            //                    DepartmentName = d?.DepartmentName ?? "No Department"
            //                };


            // ============================================================
            // LINQ LEFT JOIN
            // ============================================================
            //
            // LEFT JOIN means:
            // Keep ALL records from the LEFT collection,
            // even if there is no matching record in the RIGHT collection.
            //
            // Query Syntax pattern:
            //
            // from x in firstCollection
            // join y in secondCollection
            //     on x.Key equals y.Key
            //     into groupName
            // from y in groupName.DefaultIfEmpty()
            // select ...
            //
            // Important:
            //     DefaultIfEmpty() → keeps the LEFT record when no
            //                        matching RIGHT record exists.
            //
            // Method Syntax pattern:
            //
            // firstCollection
            //     .GroupJoin(
            //         secondCollection,
            //         x => x.Key,
            //         y => y.Key,
            //         (x, group) => ...
            //     )
            //     .SelectMany(
            //         x => x.Group.DefaultIfEmpty(),
            //         (x, y) => ...
            //     );
            //
            // Easy memory:
            //
            // INNER JOIN → Only matching records
            //
            // LEFT JOIN  → ALL LEFT records
            //              + matching RIGHT records
            //
            // Example:
            //
            // Employees                   Departments
            // Rahul  → 10  ───────────→  IT (10)
            // Priya  → 20  ───────────→  HR (20)
            // Amit   → 30  ───────────→  Nothing
            //
            // LEFT JOIN result:
            //
            // Rahul → IT
            // Priya → HR
            // Amit  → No Department
            //
            // Key concept:
            // GroupJoin() + DefaultIfEmpty() = LEFT JOIN
            // ============================================================
        }
    }
}
