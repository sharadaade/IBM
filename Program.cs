namespace IBM
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>
        {
            new Department { Id = 1, Name = "HR" },
            new Department { Id = 2, Name = "IT" },
            new Department { Id = 3, Name = "Finance" },
            new Department { Id = 4, Name = "Sales" },
            new Department { Id = 5, Name = "Marketing" }
        };

            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 101, Name = "Rahul",   Age = 25, Gender = "Male",   Salary = 35000, DepartmentId = 2 },
            new Employee { Id = 102, Name = "Priya",   Age = 30, Gender = "Female", Salary = 45000, DepartmentId = 1 },
            new Employee { Id = 103, Name = "Amit",    Age = 28, Gender = "Male",   Salary = 55000, DepartmentId = 2 },
            new Employee { Id = 104, Name = "Sneha",   Age = 24, Gender = "Female", Salary = 32000, DepartmentId = 5 },
            new Employee { Id = 105, Name = "Karan",   Age = 35, Gender = "Male",   Salary = 70000, DepartmentId = 3 },
            new Employee { Id = 106, Name = "Anjali",  Age = 29, Gender = "Female", Salary = 48000, DepartmentId = 4 },
            new Employee { Id = 107, Name = "Vikram",  Age = 32, Gender = "Male",   Salary = 62000, DepartmentId = 2 },
            new Employee { Id = 108, Name = "Pooja",   Age = 27, Gender = "Female", Salary = 39000, DepartmentId = 1 },
            new Employee { Id = 109, Name = "Rohit",   Age = 26, Gender = "Male",   Salary = 41000, DepartmentId = 4 },
            new Employee { Id = 110, Name = "Neha",    Age = 31, Gender = "Female", Salary = 68000, DepartmentId = 3 }
        };
        }
    }
}
