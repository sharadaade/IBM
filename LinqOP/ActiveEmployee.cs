using IBM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class ActiveEmployee
    {
        static void Main(string[] args)
        {
            var empList = DataList.GetEmployees();
            var depList = DataList.GetDepartments();


            // ===========================================================
            // WHERE()
            // Purpose: Filters the collection based on a condition.
            // Returns: Original Employee objects that satisfy the condition.
            // It does NOT change the object or select specific properties.
            // ===========================================================

            // If IsActive is already bool, writing == true is optional.
            var onlyActiveEmployee = empList.Where(x => x.IsActive);

            foreach (var item in onlyActiveEmployee)
            {
                Console.WriteLine($"Name : {item.Name} Salary : {item.Salary} Age : {item.Age} DeptID : {item.DepartmentId}");
            }

            // ===========================================================
            // SELECT()
            // Purpose: Projects (selects) specific properties or creates
            // a new object from each item.
            // Returns: Only the data you specify.
            // It does NOT filter the collection.
            // ===========================================================

            // Select only the Name property
            // var employeeNames = empList.Select(x => x.Name);

            // Select Name and Salary
            var employeeDetails = empList.Select(x => new
            {
                x.Name,
                x.Salary
            });

            foreach (var item in employeeDetails)
            {
                Console.WriteLine($"Name : {item.Name} Salary : {item.Salary}");
            }

            // ===========================================================
            // WHERE() + SELECT()
            // Purpose:
            // 1. Where() filters the records based on a condition.
            // 2. Select() chooses only the required properties from the
            //    filtered records.
            //
            // Execution Order:
            // Step 1: Where() filters the data.
            // Step 2: Select() projects (selects) only the required data.
            //
            // Returns:
            // Only the selected properties of the filtered records.
            // ===========================================================

            // Select Name and Salary of Active Employees
            var activeEmployeeDetails = empList
                .Where(x => x.IsActive)     // Filter only active employees
                .Select(x => new            // Select only the required properties
                {
                    x.Name,
                    x.Salary
                });

            foreach (var item in activeEmployeeDetails)
            {
                Console.WriteLine($"Name : {item.Name} Salary : {item.Salary}");
            }

        }
    }
}
