using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IBM.LinqOP
{
    internal class OfTypeMethod
    {
        static void Main(string[] args)
        {
            // Filters the elements of an IEnumerable based on a specified type.
            ArrayList fruits = new(){
                                        "Mango",
                                        "Orange",
                                        null,
                                        "Apple",
                                        3.0,
                                        "Banana",
                                        "Nano"
                                    };


            IEnumerable<string> query1 = fruits.OfType<string>();

            Console.WriteLine("Elements of type 'string' are:");
            foreach (string fruit in query1)
            {
                Console.WriteLine(fruit);
            }


            IEnumerable<string> query2 = fruits.OfType<string>()
                                               .Where(fruit =>
                                                      fruit.Contains('n', StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("\nThe following strings contain 'n':");
            foreach (string fruit in query2)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
