using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    internal class MinByMethod
    {
        static void Main(string[] args)
        {
            List<Walk> walks = new List<Walk>()
                               {
                                    new Walk { Id = 1, Name = "Mountain Walk", LengthInKm = 12 },
                                    new Walk { Id = 2, Name = "Forest Walk", LengthInKm = 5 },
                                    new Walk { Id = 3, Name = "Lake Walk", LengthInKm = 8 }
                               };

            var longestWalk = walks.MinBy(w => w.LengthInKm);

            Console.WriteLine("=======================");
            Console.WriteLine("Id : " + longestWalk.Id);
            Console.WriteLine("Name : " + longestWalk.Name);
            Console.WriteLine("Length : " + longestWalk.LengthInKm);
        }
    }
}
