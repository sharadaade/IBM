using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.AdvLinq
{
    internal class WhereTest
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Where() uses deferred execution.
            // At this line, the query is created but the filtering is not normally executed yet.
            // The query executes when we enumerate it, for example with foreach, ToList(), ToArray(), etc.
            var evenNumber = numbers.Where(x => x % 2 == 0);

            // foreach enumerates evenNumber, so the Where() query executes here.
            //foreach (var number in evenNumber)
            //{
            //    Console.WriteLine(number);
            //}

            var even = numbers.NewWhere(x => x % 2 == 0);
            foreach (var i in even)
            {
                Console.WriteLine(i);
            }
        }
    }
}
