using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.LinqOP
{
    class Ps
    {
        public string Name { get; set; }
    }

    class Ptts
    {
        public string Name { get; set; }
        public Ps Owner { get; set; }
    }
    internal class GroupJoinExample
    {
        static void Main(string[] args)
        {
            Ps magnus = new Ps { Name = "Hedlund, Magnus" };
            Ps terry = new Ps { Name = "Adams, Terry" };
            Ps charlotte = new Ps { Name = "Weiss, Charlotte" };

            Ptts barley = new Ptts { Name = "Barley", Owner = terry };
            Ptts boots = new Ptts { Name = "Boots", Owner = terry };
            Ptts whiskers = new Ptts { Name = "Whiskers", Owner = charlotte };
            Ptts daisy = new Ptts { Name = "Daisy", Owner = magnus };

            List<Ps> people = new List<Ps> { magnus, terry, charlotte };
            List<Ptts> pets = new List<Ptts> { barley, boots, whiskers, daisy };


            var q = people.GroupJoin(pets, 
                                     person => person,
                                     pet => pet.Owner,
                                     (person, petCollection) =>
                                            new
                                            {
                                                OwnerName = person.Name,
                                                Ptts = petCollection.Select(pet => pet.Name)
                                            });

            foreach (var obj in q)
            {
                // Output the owner's name.
                Console.WriteLine("{0}:", obj.OwnerName);
                // Output each of the owner's pet's names.
                foreach (string pet in obj.Ptts)
                {
                    Console.WriteLine("  {0}", pet);
                }
            }
        }
    }
}
