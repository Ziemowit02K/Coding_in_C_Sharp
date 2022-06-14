// Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welome, all you have to do is: ");
            Console.WriteLine("Insert a decimal numer and confirm it");
            Console.WriteLine("Then we will convert it to binary form!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Insert decimal number: ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            {
                string result = " ";
                int number = Convert.ToInt32(numberGiven);
                while (number > 1)
                {
                    int remainder = number % 2;
                    result = remainder.ToString() + result;
                    number /= 2;
                }
                result = number.ToString() + result;
                Console.WriteLine("Binary: " + result); ;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            int i;
            if (int.TryParse(str, out i))
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
