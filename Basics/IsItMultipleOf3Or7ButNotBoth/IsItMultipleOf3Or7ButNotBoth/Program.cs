// Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(3));
            Console.WriteLine(solution(7));
            Console.WriteLine(solution(21));
            Console.ReadLine();
        }
        public static string solution(int number)
        {
            if(number%3==0 && !(number % 7 == 0))
            {
                return "True";
            }
            else if(number%7==0&& !(number % 3 == 0))
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
    }
}
