// Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. 
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine("I am going to how you sum of the series [9 + 999 + 9999+ 99999...],");
            Console.WriteLine("But you need to tell me how long this series schould be.");
            Console.WriteLine();
            Console.WriteLine("--- --- --- Press any key to continue --- --- ---");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Input number of terms: ");
            string NumberGiven =  Console.ReadLine();

            if (IsItNumber(NumberGiven))
            {

                int sum = 0;
                int result=9;
                int number = Convert.ToInt32(NumberGiven);
                for(int i = 0; i <= number-1; i++)
                {
                    sum += result;
                    Console.Write("{0}     ", result);
                    result = result * 10 + 9;


                }
                Console.WriteLine("The sum of the series = {0}", sum);
                
            }
        }
        public static bool IsItNumber(string str)
        {
            if(int.TryParse(str, out int i))
            {
                return true;
            }
            return false;
            
        }
    }
}
