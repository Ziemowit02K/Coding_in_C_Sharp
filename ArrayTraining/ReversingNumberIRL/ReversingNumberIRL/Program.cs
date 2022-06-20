//Write a program in C# Sharp to display the number in reverse order.using System;
namespace exercises
{
    class Project
    {
        static void Main()
        {
            int i, j;
            Welcome();

            Console.Write("Insert number: ");
            string numberGiven = Console.ReadLine();

            if (IsItNumber(numberGiven))
            {
                int number = Convert.ToInt32(numberGiven);
                
                
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
            if (int.TryParse(str, out int i))
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
            Console.WriteLine("             Today I am gonna display yout number,but...REVERSED! (magic)         ");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
