//Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....]. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going calculate the sum of the series[ x - x^3 + x^5 - x^7 + x^9 -.....]:,");
            Console.WriteLine("But you need to tell me how long it schould be.");
            Console.WriteLine();
            Console.WriteLine("--- --- --- Press any key to continue --- --- ---");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Input the value of x: ");
            string XGiven = Console.ReadLine();
            Console.Write("Input number for series long:  ");
            string NumberGiven = Console.ReadLine();
            if (IsItNumber(NumberGiven) && IsItNumber(XGiven))
            {
                int n = Convert.ToInt32(NumberGiven);
                int x = Convert.ToInt32(XGiven);

                double sum = 0;
                double no_row = 1;
                double ctr;
                double p = 1;
                for (double i = 1; i < n+1; i++)
                {
                    ctr = Math.Pow(x, p);
                    sum = sum + ctr*no_row;
                    no_row = no_row * (-1);
                    p = p + 2;
                }
                Console.Clear();
                Console.WriteLine("The sum of x at values: {0} and long: {1} is:   {2}", x, n, sum);

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
