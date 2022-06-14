// Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Pls insert here number you want see multiplication of.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number for multiplication from 1 to: ");
            string numbergiven = Console.ReadLine();

            if (IsItNumber(numbergiven))
            {
                int number = Convert.ToInt32(numbergiven);
                for(int i =1; i<=10; i++)
                {
                    for(int j=1; j <= number; j++)
                    {
                        
                        if (j <= number - 1)
                        {
                            Console.Write("{0}x{1}={2}, ", i, j, i * j);
                        }
                        else
                        {
                            Console.Write("{0}x{1}={2}, ", i, j, i * j);
                        }
                        


                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        public static bool IsItNumber(string str)
        {
            int i = 0;
            if(int.TryParse(str, out i))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

        