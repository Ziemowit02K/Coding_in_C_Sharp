// Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(13));
            Console.WriteLine(solution(14));
            Console.WriteLine(solution(27));
            Console.WriteLine(solution(41));
            Console.ReadLine();
        }
        public static string solution(int number)
        {
            if (number % 13 == 0 || number % 13 == 1)
            {
                return "True";
            }
            return "False";
        }
    }
}
