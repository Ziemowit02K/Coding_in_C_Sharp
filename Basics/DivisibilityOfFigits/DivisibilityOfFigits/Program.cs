using System;
namespace exercises 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(3));
            Console.WriteLine(solution(14));
            Console.WriteLine(solution(12));
            Console.WriteLine(solution(37));


        }
        public static string solution(int i)
        {
            int byThree = i % 3;
            int bySeven = i % 7;
            if (byThree==0 || bySeven==0)
            {
                return "True";
            }
            return "False";
        }
    }
}