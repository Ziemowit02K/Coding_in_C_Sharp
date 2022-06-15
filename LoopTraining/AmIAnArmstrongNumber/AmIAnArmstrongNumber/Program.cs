//Write a C# Sharp program to check whether a given number is an Armstrong number or not. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Welcome();

            Console.Write("Insert a number: ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            {
                int num = Convert.ToInt32(numberGiven);
                int sum = 0;
                int num1=0;
                int r = 0;
                for (num1 = num; num != 0; num = num / 10)
                {
                    r = num % 10;
                    sum = sum + (r * r * r);
                }
                if (sum == num1)
                {
                    Console.WriteLine("{0} is an Armstrong number", num1);
                }
                else
                {
                    Console.WriteLine("{0} is not an Armstrong number", num1);
                }
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
            if(int.TryParse(str,out int i))
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
                    Console.WriteLine("        Today I am gonna tell you is your number an ARMSTRONG number");
                    Console.WriteLine();
                    Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
                    Console.ReadKey();
                    Console.Clear();
            
                
            }
        }
    }


