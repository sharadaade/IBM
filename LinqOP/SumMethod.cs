using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    class Package
    {
        public string Company { get; set; }
        public double Weight { get; set; }
    }
    internal class SumMethod
    {
        static void Main(string[] args)
        {
            List<float> numbers = new List<float> { 43.68F, 1.25F, 583.7F, 6.5F };

            float sum = numbers.Sum();



            float?[] points = { null, 0, 92.83F, null, 100.0F, 37.46F, 81.1F };

            float? sum1 = points.Sum();


            List<Package> packages = new List<Package>
                                    {   new Package { Company = "Coho Vineyard", Weight = 25.2 },
                                        new Package { Company = "Lucerne Publishing", Weight = 18.7 },
                                        new Package { Company = "Wingtip Toys", Weight = 6.0 },
                                        new Package { Company = "Adventure Works", Weight = 33.8 } 
                                    };

            double totalWeight = packages.Sum(pkg => pkg.Weight);


        }
    }
}
