using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    class Pets
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

        

    internal class ConcatMethod
    {
        static void Main(string[] args)
        {
            Pets[] GetCats()
            {
                Pets[] cats = { new Pets { Name="Barley", Age=8 },
                                new Pets { Name="Boots", Age=4 },
                                new Pets { Name="Whiskers", Age=1 } };
                return cats;
            }

            Pets[] GetDogs()
            {
                Pets[] dogs = { new Pets { Name="Bounder", Age=3 },
                                new Pets { Name="Snoopy", Age=14 },
                                new Pets { Name="Fido", Age=9 } };
                return dogs;
            }

            Pets[] cats = GetCats();
            Pets[] dogs = GetDogs();

            // Way - 1
            IEnumerable<string> query = cats.Select(c => c.Name)
                                            .Concat(dogs.Select(d => d.Name))
                                            .OrderBy(x => x);


            // Way - 2
            IEnumerable<string> qyery1 = new[] { cats.Select(c => c.Name), dogs.Select(d => d.Name) }.SelectMany(x => x).OrderBy(x => x);

            Console.WriteLine();
        }
    }
}
