using System;
namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(100, 199));
            Console.WriteLine(solution(250, 300));
            Console.WriteLine(solution(105, 190));
            Console.ReadLine();
        }
        public static bool solution(int i1, int i2)
        {
            return i1 > 100 && i2 < 200 || i2 > 100 && i1 < 200; 
        }
    }
}