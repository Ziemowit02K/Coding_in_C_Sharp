// Write a program in C# Sharp to display the multiplication table of a given integer.
using System;
namespace multiplicationtable
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Pls insert here number you want see multiplication of.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert number for multiplication: ");
            string numbergiven = Console.ReadLine();
            if (IsItNumber(numbergiven))
            {
                int number = Convert.ToInt32(numbergiven);
                for(int i = 1; i < 11; i++)
                {
                    Console.WriteLine("Number - {0}, multiplication by {1} looks like: {2} * {3} = {4}",number,i,number,i,number*i);
                }
            }
        }
        public static bool IsItNumber(string str)
        {
            int i;
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
