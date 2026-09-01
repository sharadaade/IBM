using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Data
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal static class DataList
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 101, Name = "Rahul", Age = 25, Gender = "Male", Salary = 35000, DepartmentId = 2, IsActive = true },
                new Employee { Id = 102, Name = "Priya", Age = 30, Gender = "Female", Salary = 45000, DepartmentId = 1, IsActive = false },
                new Employee { Id = 103, Name = "Amit", Age = 28, Gender = "Male", Salary = 55000, DepartmentId = 2, IsActive = true },
                new Employee { Id = 104, Name = "Sneha", Age = 24, Gender = "Female", Salary = 32000, DepartmentId = 5, IsActive = true },
                new Employee { Id = 105, Name = "Karan", Age = 35, Gender = "Male", Salary = 70000, DepartmentId = 3, IsActive = false },
                new Employee { Id = 106, Name = "Anjali", Age = 29, Gender = "Female", Salary = 48000, DepartmentId = 4, IsActive = false },
                new Employee { Id = 107, Name = "Vikram", Age = 32, Gender = "Male", Salary = 62000, DepartmentId = 2, IsActive = true },
                new Employee { Id = 108, Name = "Pooja", Age = 27, Gender = "Female", Salary = 39000, DepartmentId = 1, IsActive = false },
                new Employee { Id = 109, Name = "Rohit", Age = 26, Gender = "Male", Salary = 41000, DepartmentId = 4, IsActive = true },
                new Employee { Id = 110, Name = "Neha", Age = 31, Gender = "Female", Salary = 68000, DepartmentId = 3, IsActive = true }
            };
        }

        public static List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "IT" },
                new Department { Id = 3, Name = "Finance" },
                new Department { Id = 4, Name = "Sales" },
                new Department { Id = 5, Name = "Marketing" }
            };
        }
    }
}
