// Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, you need to insert number of rows in your future triangle");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number of rows:  ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            {
                int number = Convert.ToInt32(numberGiven);
                for (int i = 1; i <= number; i++)
                {
                    
                    for (int j = 1; j <= i; j++)
                    {
                        int display = i;
                        Console.Write(display);
                        display++;
                    }
                    Console.WriteLine();
                    
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
