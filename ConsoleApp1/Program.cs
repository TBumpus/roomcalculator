using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our room detail generator!");
            Console.WriteLine("Please enter a length");

            double length = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Please enter a width");
            
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a height");

            double height = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = length * 2 + width * 2;
            double volume = length * width * height;
            double surface = 2 * (length * width + height * length + width * height);
            
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Volume: {0}", volume);
            Console.WriteLine("Surface Area: {0}", surface);
            Console.WriteLine();

            if (area < 251)
            {
                Console.WriteLine("This is a small room.");
            }
            else if (area < 651)
            {
                Console.WriteLine("This is a medium room");
            }
            else if (area > 650)
            {
                Console.WriteLine("This is a large room");
            }

            Console.WriteLine("Thank you for using our room detail generator!");


        }

    }
}