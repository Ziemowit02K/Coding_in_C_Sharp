using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(78,95));
            Console.WriteLine(solution(25, 35));
            Console.WriteLine(solution(40, 50));
            Console.WriteLine(solution(55, 60));
            Console.ReadLine();
        }
        public static string solution(int i1, int i2)
        {
            if((i1>=40 && i1<=50 || i2>=40 && i2 <= 50) || (i1>=50 && i1<=60 && i2>=50 && i2<=60))
            {
                return "True";
            }
            return "False";
        }
    }
}