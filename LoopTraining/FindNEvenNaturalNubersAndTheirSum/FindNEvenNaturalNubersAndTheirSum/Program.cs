// Write a program in C# Sharp to display the n terms of even natural number and their sum.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, you need to insert number of even numbers you want to display");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number:  ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            {
                int number = Convert.ToInt32(numberGiven);
                for(int i=1; i <= number*2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
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

