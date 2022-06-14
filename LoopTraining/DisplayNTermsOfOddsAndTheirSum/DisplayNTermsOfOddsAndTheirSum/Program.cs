// Write a program in C# Sharp to display the n terms of odd natural number and their sum.
using System;
namespace exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, I will show you so many odss as you like.");
            Console.WriteLine("");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number of terms: ");
            string numberGiven = Console.ReadLine();

            Console.WriteLine("The {0} odds numbers are: ",numberGiven);
            if (IsItNumber(numberGiven))
            {
                int n = Convert.ToInt32(numberGiven);
                int summary = 0;
                for(int i = 0;i <= n*2; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i + ", ");
                        summary += i;
                    }
                }
                Console.WriteLine("The summ of {0} odss : {1}",n,summary);
                
            }
            else
            {
                Console.WriteLine("Wrong type of input");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            int i;
            if(int.TryParse(str, out i))
            {
                return true;
            }
            return false;
        }
    }
}
