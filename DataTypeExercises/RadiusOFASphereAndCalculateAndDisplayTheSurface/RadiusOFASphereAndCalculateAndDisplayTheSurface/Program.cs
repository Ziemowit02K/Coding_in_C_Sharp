//Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere

using System;
namespace exercise {
    public class Program
    {
        public static void Main()
        {
            double pi = (3.14);
            Console.Write("Input radius: ");
            string radiusGiven = Console.ReadLine();
            if (IsItNumber(radiusGiven))
            {
                double radius;
                double.TryParse(radiusGiven, out radius);
                double Volume = (4 * pi * radius * radius * radius)/3;
                double Area = 4 * pi * radius * radius;

                Console.WriteLine("Volume is: " + Volume);
                Console.WriteLine("Area is: " + Area);

            }
    }
        public static bool IsItNumber(string str)
        {
            double num;
            if (double.TryParse(str, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}