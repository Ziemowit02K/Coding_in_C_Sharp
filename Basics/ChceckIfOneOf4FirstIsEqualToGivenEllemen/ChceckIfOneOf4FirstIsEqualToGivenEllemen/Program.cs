using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new[] {1, 2, 9, 3} ,3));
            Console.WriteLine(solution(new[] { 1, 2, 3 , 4, 5, 6 }, 2));
            Console.WriteLine(solution(new[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();

        }
        public static bool solution(int[] numbers,int a)
        {
            if (numbers.Length>=4 && numbers.Take(4).Contains(a))
            {
                return true;
            }
            return false;
        }
    }
}