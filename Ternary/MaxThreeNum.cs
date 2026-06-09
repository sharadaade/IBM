using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Ternary
{
    internal class MaxThreeNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter the 2nd number : ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Enter the 2nd number : ");
            int third = int.Parse(Console.ReadLine());

            int max = (first > second && first > third) ? first :
                        (second > third) ? second : third;

            Console.WriteLine($"Max is : {max}");
        }
    }
}
