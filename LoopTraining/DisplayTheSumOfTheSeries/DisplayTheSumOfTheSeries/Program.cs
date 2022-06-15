//Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....]. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going calculate the sum of the series [ 1+x+x^2/2!+x^3/3!+....]:,");
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
               int n= Convert.ToInt32(NumberGiven);
               int x = Convert.ToInt32(XGiven);

                decimal sum = 1;
                decimal no_row = 1;
                for (decimal i = 1; i < n; i++)
                {
                    no_row = no_row * x / i;
                    sum = sum + no_row;
                }
                Console.Clear();
                Console.WriteLine("The sum of x at values: {0} and long: {1} is:   {2}",x,n,sum);
                
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
