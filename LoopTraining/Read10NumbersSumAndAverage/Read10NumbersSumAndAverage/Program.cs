// Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            int result = 0;
            Console.WriteLine("Welcome!");
            for(int i = 1; i < 11; i++)
            {
                Console.Write("Number-" + i + ": ") ;
                int number = Convert.ToInt32(Console.ReadLine());

                result +=number;
                
            }
            double average = result / 10;
            Console.WriteLine("The sum of 10 numbers is: "+result);
            Console.WriteLine("The Average is: " + average);
        }
        
    }
}
