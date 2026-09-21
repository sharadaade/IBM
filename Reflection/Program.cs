using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace IBM.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom(@"C:\MyData\VSCode\PrintAll\bin\Debug\net10.0\PrintAll.dll");

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine($"Type : {type.Name}");
                Console.WriteLine("========================");

                foreach(var fiels in type.GetFields(BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly ))
                {
                    Console.WriteLine($"Field : {fiels.Name}");
                }
                Console.WriteLine("========================");
                foreach(var method in type.GetMethods(BindingFlags.NonPublic |
                    BindingFlags.Public | 
                    BindingFlags.Instance |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Method : {method.Name}");
                }
                Console.WriteLine("=======================");

                foreach(var property in type.GetProperties())
                {
                    Console.WriteLine($"Property : {property.Name}");
                }
            }
        }
    }
}
