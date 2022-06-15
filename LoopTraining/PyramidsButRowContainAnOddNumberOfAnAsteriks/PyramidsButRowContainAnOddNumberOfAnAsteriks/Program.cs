//  Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, you need to insert number of rows in your future pyramid (i am going to show only odds)");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number of rows:  ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            {

                int number = Convert.ToInt32(numberGiven);
                int space;
                int display = number;
                for (int i = 0; i <= number; i++)
                {
                    for (space = display; space >=1; space--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i*2+1; j++)
                    {
                    
                            Console.Write("*");
                        
                    }
                    Console.WriteLine();


                    display--;
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
