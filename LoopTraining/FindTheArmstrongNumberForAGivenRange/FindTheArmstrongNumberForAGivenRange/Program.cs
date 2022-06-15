//Write a C# Sharp program to find the Armstrong number for a given range of number. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Welcome();

            Console.Write("Insert a starting number of range: ");
            string numberStartingGiven = Console.ReadLine();

            Console.Write("Insert ending number of range: ");
            string numberEndingGiven = Console.ReadLine();

            if (IsItNumber(numberStartingGiven) && IsItNumber(numberEndingGiven))
            {
                int numStarts = Convert.ToInt32(numberStartingGiven);
                int numEnds = Convert.ToInt32(numberEndingGiven);
                int sum ,temp;
                int num ,r;
                Console.Write("Armstrongs numbers in given range are: ");
                for (num = numStarts; num <= numEnds; num++)
                {
                    temp = num;
                    sum = 0;
                    while(temp != 0)
                    {
                        r = temp % 10;
                        temp = temp / 10;
                        sum = sum + (r * r * r);
                    }
                    if (sum == num)
                    {
                        Console.Write("{0} ", num);
                    }
                    
                }
                Console.WriteLine();

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
            Console.WriteLine("        Today I am gonna tell you is what numbers are an ARMSTRONG number");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();


        }
    }
}


