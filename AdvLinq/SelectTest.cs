using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.AdvLinq
{
    internal class SelectTest
    {
        static void Main(string[] args)
        {
            var customers = new[]
            {
                new Customer { Name = "Jon", 
                               Phones = new [] 
                               { 
                                   new Phone { Number ="123", PhoneType = PhoneType.Cell },
                                   new Phone { Number ="456", PhoneType = PhoneType.Cell }
                               } },
                new Customer { Name = "Jane",
                               Phones = new [] 
                               {
                                   new Phone { Number ="345-345-3456", PhoneType = PhoneType.Cell },
                                   new Phone { Number ="567-678-5678", PhoneType = PhoneType.Cell }
                               } }
            };

            // Select()
            var customerNames = customers.Select(c => c.Name);

            foreach(var item in customerNames)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();

            var customerPhones = customers.SelectMany(c => c.Phones);
            foreach (var item in customerPhones)
            {
                Console.WriteLine($"{item.Number} - {item.PhoneType}");
            }


        }
    }
}
