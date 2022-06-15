//Write a C# Sharp program to check whether a given number is perfect number or not. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going calculate if your number is perfect number or not ");
            Console.WriteLine("But you need to tell me the number");
            Console.WriteLine();
            Console.WriteLine("--- --- --- Press any key to continue --- --- ---");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Input number:  ");
            string NumberGiven = Console.ReadLine();
            Console.Clear();
            if (IsItNumber(NumberGiven))
            {
                int n = Convert.ToInt32(NumberGiven);
                int sum = 0;
                for(int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i + " ");
                        sum = sum + i;
                    }
                }
                Console.WriteLine("--- --- --- The sum is:  {0} --- --- ---",sum);
                Console.WriteLine();
                Console.WriteLine();
                if (n == sum)
                {
                    Console.WriteLine("   -- -- -- {0} is perfect -- -- --   ",n);
                    
                }
                else
                {
                    Console.WriteLine("   -- -- -- {0} is not perfect -- -- --   ", n);
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            if (int.TryParse(str, out int i))
            {
                return true;
            }
            return false;

        }
    }
}
