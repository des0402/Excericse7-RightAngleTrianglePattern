using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excericse7_RightAngleTrianglePattern
{
    class Program
    {
        //Write a C# Sharp program that takes a number and a width also a number,
        //as input and then displays a triangle of that width, using that number.

        static void Main(string[] args)
        {
            Console.WriteLine("***Right Angle Triangle***");
            Console.Write("\nEnter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("\nEnter width of Triangle: ");
            int width = int.Parse(Console.ReadLine());

            int height = width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(number);
                }

                Console.WriteLine();
                width--;
            }

            Console.ReadLine();
        }
    }
}
