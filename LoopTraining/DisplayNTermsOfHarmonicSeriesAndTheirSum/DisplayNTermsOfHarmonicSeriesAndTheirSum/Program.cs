// Write a program in C# Sharp to display the n terms of harmonic series and their sum.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! I am going to display the n terms of harmonic series and their sum");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Input the number of terms: ");
            string numberGiven = Console.ReadLine();

            if (IsItNumber(numberGiven))
            {
                int number = Convert.ToInt32(numberGiven);
                double result = 0;
                for(double i = 1; i <= number; i++)
                {
                    Console.Write("1/{0} + ",i);
                    result += 1 / i;
                }
                Console.WriteLine();
                Console.WriteLine("Sum of Series upto 5 terms: {0}", result);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        public static bool IsItNumber(string str)
        {
            int i = 0;
            if(int.TryParse(str, out i))
            {
                return true;
            }
            return false;
        }
    }
}
