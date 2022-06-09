using System;
namespace exercise
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(11, 20, 12));
            Console.WriteLine(solution(30, 30, 17));
            Console.WriteLine(solution(25, 35, 50));
            Console.WriteLine(solution(15, 12, 8));
        }
        public static bool solution(int i1, int i2, int i3)
        {
            return i1 >= 20 && i1 <= 50 || i2 >= 20 && i2 <= 50 || i3 >= 20 && i2 <= 50;
        }
    }
}