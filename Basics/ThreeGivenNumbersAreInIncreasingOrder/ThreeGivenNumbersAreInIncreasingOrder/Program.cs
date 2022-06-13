// Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1, 2, 3, false));
            Console.WriteLine(solution(1, 2, 3, true));
            Console.WriteLine(solution(10, 2, 30, false));
            Console.WriteLine(solution(10, 10, 30, true));
            Console.ReadLine();
        }
        public static string solution(int x, int y,int z, bool str)
        {
            if (str)
            {
                if (x<=y && y<=z)
                {
                    return "True";
                }
                return "False";
            }
            else
            {
                if(x<y && y < z)
                {
                    return "True";
                }

            }
            return "False";
        }
    }
}
