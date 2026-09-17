using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    class Packages
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }
    }
    internal class ToDictionaryMethod
    {
        static void Main(string[] args)
        {
            List<Packages> packages = new List<Packages>
                                        { 
                                            new Packages { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
                                            new Packages { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
                                            new Packages { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
                                            new Packages { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L } 
                                        };

            // Create a Dictionary of Package objects,
            // using TrackingNumber as the key.
            Dictionary<long, Packages> dictionary = packages.ToDictionary(p => p.TrackingNumber);

            foreach (KeyValuePair<long, Packages> kvp in dictionary)
            {
                Console.WriteLine($"Key {kvp.Key}: {kvp.Value.Company}, {kvp.Value.Weight} pounds");
            }
        }
    }
}
