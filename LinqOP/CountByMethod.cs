using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class CountByMethod
    {
        static void Main(string[] args)
        {
            (string Name, int Age, string Department)[] employees = {
                                                                        ("Saly", 23, "IT"),
                                                                        ("David", 25, "Sales"),
                                                                        ("Mahmoud", 22, "IT"),
                                                                        ("Qamar", 22, "HR"),
                                                                        ("Sara", 25, "IT"),
                                                                        ("John", 26, "HR"),
                                                                        ("Jaffar", 32, "Sales")
                                                                     };


            var countPerDepartment = employees.CountBy(emp => emp.Department);

            foreach(var item in countPerDepartment)
            {
                Console.WriteLine($"Department : {item.Key} - Employee Count : {item.Value}");
            }
        }
    }
}
