// Write a C# Sharp program to calculate the factorial of a given number.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, you need to insert number you want to know the factorial of.");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number:  ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            { 
                int number = Convert.ToInt32(numberGiven);
                int result=1;
                for(int i = number; i >= 1; i--)
                {
                    result *= i;
                }
                Console.WriteLine("The Factorial of {0} is: {1}",number,result);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong Input");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            int i;
            if (int.TryParse(str, out i))
            {
                return true;
            }
            return false;

        }
    }
}

