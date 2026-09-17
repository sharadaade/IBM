using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    public class Walk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double LengthInKm { get; set; }
    }

    internal class MaxByMethod
    {
        static void Main(string[] args)
        {
            List<Walk> walks = new List<Walk>()
                               {
                                    new Walk { Id = 1, Name = "Mountain Walk", LengthInKm = 12 },
                                    new Walk { Id = 2, Name = "Forest Walk", LengthInKm = 5 },
                                    new Walk { Id = 3, Name = "Lake Walk", LengthInKm = 8 }
                               };

            var longestWalk = walks.MaxBy(w => w.LengthInKm);

            Console.WriteLine("=======================");
            Console.WriteLine("Id : " + longestWalk.Id);
            Console.WriteLine("Name : " + longestWalk.Name);
            Console.WriteLine("Length : " + longestWalk.LengthInKm);
        }
    }
}
