using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(solution(new[] {1, 1, 2, 4 ,1}));
            Console.WriteLine(solution(new[] {1, 1, 2, 1, 2, 3}));
            Console.ReadLine();
        }
        public static bool solution(int[] numbers)
        {
            for(int i=0;i<numbers.Length-2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                    return true;

            }
            return false;
        }
    }
}