//Write a program in C# Sharp to display the pattern like a diamond
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Welcome();

            Console.Write("Insert how much '*' wide schould it be: ");
            string numberGiven = Console.ReadLine();

            if (IsItNumber(numberGiven))
            {
                
                int number = Convert.ToInt32(numberGiven);
                for (int i= 0; i <= number; i++)
                {
                    for(int k = 1; k <= number-i; k++)
                    {
                        Console.Write(" ");
                    }
                    for(int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
                for (int i = number - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= number - i; j++)
                    {
                        Console.Write(" ");
                    }
                    
                    for(int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
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
            Console.WriteLine("        Today I am gonna show you the biggest diamond you have ever seen");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();


        }
    }
}


