using System;
using System.Collections.Generic;
using System.Text;
using IBM.Data;

namespace IBM.LinqOP
{
    class Pt
    {
        public string Name { get; set; }
        public double Age { get; set; }
    }
    internal class GroupByMethod
    {
        static void Main(string[] args)
        {

            // Example - 1
            // Create a list of pets.
            List<Pt> petsList = new List<Pt>
                                { 
                                      new Pt { Name= "Barley", Age = 8.3 },
                                      new Pt { Name= "Boots", Age = 4.9 },
                                      new Pt { Name= "Whiskers", Age = 1.5 },
                                      new Pt { Name= "Daisy", Age = 4.3 }
                                };

            // Group Pet.Age values by the Math.Floor of the age.
            // Then project an anonymous type from each group
            // that consists of the key, the count of the group's
            // elements, and the minimum and maximum age in the group.

            var query = petsList.GroupBy( pet => Math.Floor(pet.Age),
                                          pet => pet.Age,
                                          (baseAge, ages) => new
                                          {
                                                Key = baseAge,
                                                Count = ages.Count(),
                                                Min = ages.Min(),
                                                Max = ages.Max()
                                          });

            foreach (var result in query)
            {
                Console.WriteLine("\nAge group: " + result.Key);
                Console.WriteLine("Number of pets in this age group: " + result.Count);
                Console.WriteLine("Minimum age: " + result.Min);
                Console.WriteLine("Maximum age: " + result.Max);
            }


            // Example -2 
            List<Pet> pets = new List<Pet>
                             { 
                                   new Pet { Name = "Barley", Age= 8 },
                                   new Pet { Name = "Boots", Age= 4 },
                                   new Pet { Name = "Whiskers", Age= 1 },
                                   new Pet { Name = "Daisy", Age= 4 } 
                             };

            // Group the pets using Age as the key value
            // and selecting only the pet's Name for each value.
            IEnumerable<IGrouping<int, string>> query1 = pets.GroupBy(pet => pet.Age, pet => pet.Name);

            // Iterate over each IGrouping in the collection.

            foreach (IGrouping<int, string> petGroup in query1)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(petGroup.Key);
                // Iterate over each value in the
                // IGrouping and print the value.
                foreach (string name in petGroup)
                {
                    Console.WriteLine("  {0}", name);
                }
            }




            // ==================== *** ====================
            List<Employee> emps = DataList.GetEmployees();

            List<Department> depts = DataList.GetDepartments();

            //var deptWiseEmployeeCount = emps


            Console.WriteLine();
            
        }
    }
}
