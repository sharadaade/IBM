using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class SingleOrDefaultMethod
    {
        static void Main(string[] args)
        {
            // Ex - 1
            string[] fruits1 = { "orange" };

            string? fruit1 = fruits1.SingleOrDefault();

            Console.WriteLine(fruit1);


            // Ex - 2 
            string[] fruits2 = { };

            string? fruit2 = fruits2.SingleOrDefault();

            Console.WriteLine(
                String.IsNullOrEmpty(fruit2) ? "No such string!" : fruit2);

        }
    }
}
