// Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
using System;
namespace exercises
{
    class Project
    {
        static void Main()
        {
            Console.Write("How many rows would you like: ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven))
            {
                int nums = Convert.ToInt32(numberGiven);
                
                for (int i = 1; i < nums; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                    ;

                }

            /*for(int i = nums; i >1 ; i--)
                {
                    for(int j=nums; j>=1; j--)
                    {
                        Console.Write("*");
                        
                    }
                    Console.WriteLine();
                    nums--;

                }*/
        }
            else
            {
                Console.WriteLine("Wrong input");
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
