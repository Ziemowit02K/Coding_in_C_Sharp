// Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome! to function calculating!");
            Console.WriteLine("Function we will check for you: x = y^2 + 2y + 1");
            Console.WriteLine("All you have to do is give us 'y' from range (-5 to +5) and we will give you 'x'");
            Console.WriteLine();
            Console.WriteLine("Press anything to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Input 'y': ");
                string yGiven = Console.ReadLine();
            if (!(IsItNumber(yGiven)))
            {
                Console.WriteLine("It is not a number");
                Console.ReadKey();
            }
            else
            {
                int yNumber = Convert.ToInt32(yGiven);
                    if(yNumber>=-5 && yNumber <= +5)
                    {
                    double x = (yNumber * yNumber) + (2 * yNumber) + 1;
                    Console.WriteLine("Your 'x' = "+x);

                    }
                else
                {
                    Console.WriteLine("Your 'y' is out of range");
                    Console.ReadKey();
                }
                
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
