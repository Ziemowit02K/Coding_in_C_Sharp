//Write a C# Sharp program to display by Pascal's triangle.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Welcome();

            Console.Write("Insert number of rows: ");
            string numberGiven = Console.ReadLine();
            Console.Clear();
            if (IsItNumber(numberGiven))
            {
                int ctr = 1;
                int number = Convert.ToInt32(numberGiven);

                for(int i = 0; i <= number-1; i++)
                {
                    for(int j = 1; j <= number - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int j= 0; j <=i; j++)
                    {
                        if (j == 0 || i == 0)
                            ctr = 1;
                        else
                            ctr = ctr * (i - j + 1) / j;
                        Console.Write("{0} ",ctr);
                    }
                    Console.WriteLine();
                }
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
            Console.WriteLine("                       --- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Today I am gonna show you Pascal's triangle, but you need to tell me how much rows you want");
            Console.WriteLine();
            Console.WriteLine("                 -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();


        }
    }
}


