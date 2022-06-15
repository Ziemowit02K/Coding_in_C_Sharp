//Write a program in C# Sharp to display the n terms of square natural number and their sum. Go to the editor 1 4 9 16... n Terms
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going calculate the sum of the n first squares of natural numbers,");
            Console.WriteLine("But you need to tell me how many nubers schould it be.");
            Console.WriteLine();
            Console.WriteLine("--- --- --- Press any key to continue --- --- ---");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Input number for series long:  ");
            string NumberGiven = Console.ReadLine();
            if (IsItNumber(NumberGiven))
            {
                int n = Convert.ToInt32(NumberGiven);
                int sum = 0;
                for(int i = 1; i <= n; i++)
                {
                    Console.Write("The sqaure of {0} is:  {1}", i, i * i);
                    Console.WriteLine();
                    sum = sum + i * i;
                }
                Console.WriteLine();
                Console.WriteLine("--- --- ---- The sum of {0} first number squares is:  {1} --- --- ---",n,sum);
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
