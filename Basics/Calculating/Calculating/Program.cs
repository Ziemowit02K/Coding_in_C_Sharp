// Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(11, 21, 31));
            Console.WriteLine(solution(11, 22, 31));
            Console.WriteLine(solution(10, 20, 15));
            Console.ReadLine();
        }
        public static string solution(int x, int y, int z)
        {
            if((x-y)>=20 || (x-z)>=20 || (y - x) >= 20 || (y - z) >= 20 || (z - x) >= 20 || (z - y) >= 20)
            {
                return "True";
            }
            return "False";
        }
    }
}
