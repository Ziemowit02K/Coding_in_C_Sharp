//Write a C# Sharp program to determine whether a given number is prime or not
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Welcome();

            Console.Write("Insert number you want to check: ");
            string numberGiven = Console.ReadLine();
            Console.Clear();
            if (IsItNumber(numberGiven))
            {
                int ctr=0;
                int number = Convert.ToInt32(numberGiven);
                for (int i= 2; i <= number-1; i++)
                {
                    if (number % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && number != 1)
                {
                    Console.WriteLine("   {0} is a prime number",number);
                }
                else
                {
                    Console.WriteLine("   {0} is not a prime number", number);
                }
            }
            else
            {
                Console.WriteLine("WrongInput");
                Console.ReadKey();
                Console.Clear();
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
        public static void Welcome()
        {
            Console.WriteLine("                     --- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        Today I am gonna show you do your number is prime or not, just it");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();


        }
    }
}


