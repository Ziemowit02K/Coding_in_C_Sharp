// Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome! To circle calulations," );
            Console.WriteLine("all you have to do is input radius of the cicle and computer is going to make some calculations for you :)");
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
            Console.WriteLine("Input circle radius: ");
                string RadiusGiven = Console.ReadLine();
            if (!IsItNumber(RadiusGiven))
            {
                Console.Clear();
                Console.WriteLine("Its not a number");
                Console.ReadKey();
            }
            else
            {
                int Radius = Convert.ToInt32(RadiusGiven);
                double Pi = (3.14);
                double Perimeter = 2 * Pi * Radius;

                double CircleField = Pi * Radius * Radius;
                Console.Clear();
                Console.WriteLine("Perimeter of Cicle: " + Perimeter);
                Console.WriteLine(" ");
                Console.WriteLine("Field of Cicle: " + CircleField);
                Console.ReadKey();

            }
        }
        public static bool IsItNumber(string str)
        {
            double number;
            if (double.TryParse(str, out number))
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
