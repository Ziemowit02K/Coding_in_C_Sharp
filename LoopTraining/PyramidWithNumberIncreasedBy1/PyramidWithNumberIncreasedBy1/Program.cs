// Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1
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
                int display = 1;
                int number = Convert.ToInt32(numberGiven);
                int space;
                for (int i = 1; i <= number; i++)
                {
                    for( space = number; space >= display; space--)
                    {
                        Console.Write(" ");
                        
                    }
                    for (int j = 1; j <= i; j++)
                    {

                        Console.Write(" "+display + " ");
                        display++;
                    }
                    Console.WriteLine();
                    space = 0;
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
