// Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome, we will check if two numbers you will input are even or odds");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Input first number: ");
            string num1Given = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            string num2Given = Console.ReadLine();
            if (IsItNumber(num1Given))
            { 
                if (IsItNumber(num2Given))
                {
                    int n1 = Convert.ToInt32(num1Given);
                    int n2 = Convert.ToInt32(num2Given);

                    if(n1%2==0 && n2 % 2 == 0)
                    {
                        Console.WriteLine($"{n1} and {n2} are even");
                    }
                    else if ((n1%2!=0) && (n2 % 2 != 0))
                    {
                        Console.WriteLine($"{n1} and {n2} are both odds");
                    }
                    else if((n1 % 2 == 0) && (n2 % 2 != 0))
                    {
                        Console.WriteLine($"{n1} is even and {n2} is odd");
                    }
                    else if ((n1 % 2 != 0) && (n2 % 2 == 0))
                    {
                        Console.WriteLine($"{n1} is odd and {n2} is even");
                    }
                    else
                    {
                        Console.WriteLine("something is wrong");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again");
            }
        }

        public static bool IsItNumber(string i)
        {
            int n;
            if (int.TryParse(i, out n))
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
