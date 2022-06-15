//Write a program in C# Sharp to print the Floyd's Triangle.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going to build Floyd's Triangle,");
            Console.WriteLine("But you need to tell me how long it schould be.");
            Console.WriteLine();
            Console.WriteLine("--- --- --- Press any key to continue --- --- ---");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Input number of rows:  ");
            string NumberGiven = Console.ReadLine();
            int n = 0;
            if (IsItNumber(NumberGiven))
            {
                int number = Convert.ToInt32(NumberGiven);
                int display = number;
                int p;
                int q;
                for (int i =0; i < number; i++)
                {
                    if (i % 2 == 0)
                    {
                         p = 1;
                         q = 0;
                    }
                    else
                    {
                         p = 0;
                         q = 1;
                    }
                    for(int j=0;j<=i; j++)
                    {
                        if (j %2== 0)
                        {
                            Console.Write(p);
                        }
                        else
                        {
                            Console.Write(q);
                        }

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
    }
}
