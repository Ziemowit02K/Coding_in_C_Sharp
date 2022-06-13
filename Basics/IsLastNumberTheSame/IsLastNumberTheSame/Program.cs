// Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution( 11, 21, 31 ));
            Console.WriteLine(solution( 11, 22, 31 ));
            Console.WriteLine(solution( 11, 22, 33 ));
        }
        public static string solution(int x, int y, int z)
        {
            if( x % 10 == y % 10 || x % 10 == z % 10 || y % 10 == z % 10)
            {
                return "True";
            }
            return "False";

        }
    }

}
