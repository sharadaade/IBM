using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Basics
{
    internal class AngleOfTriangle
    {
        public int GetThirdAngle(int angle1, int angle2)
        {
            return (180 - (angle1 + angle2));
        }
        static void Main(string[] args)
        {
            int num1, num2, sum;
            string input1, input2;

            Console.Write("Enter the 1st Angle : ");
            input1 = Console.ReadLine();

            Console.Write("Enter the 2nd Angle : ");
            input2 = Console.ReadLine();

            if(int.TryParse(input1, out num1) && int.TryParse(input2,out num2))
            {
                AngleOfTriangle obj = new AngleOfTriangle();
                sum = obj.GetThirdAngle(num1, num2);
                Console.WriteLine("3rd angle is : " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}
