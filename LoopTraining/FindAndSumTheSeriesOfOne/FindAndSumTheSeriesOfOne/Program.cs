//Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going calculate the sum of the series 1 +11 + 111 + 1111 + .. n terms. ");
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
                int k = 1;
                for(int i=0; i<=n; i++)
                {
                    sum = sum + k;
                    k = (k * 10)+1;
                    Console.Write("{0} + ",k);
                    
                }
                Console.WriteLine();
                Console.WriteLine("--- --- ---- The sum is:  {0} --- --- ---", sum);
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
