using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IBM.LinqOP
{
    internal class ShuffleMethod
    {
        static void Main(string[] args)
        {

            var items = new List<string> { "Apple", "Banana", "Cherry", "Date" };

            // Returns a new shuffled sequence without mutating the original list
            var shuffled = items.Shuffle();

            // You can also pass a specific Random instance if needed
            //var customShuffled = items.Shuffle(Random.Shared);

        }
    }
}
