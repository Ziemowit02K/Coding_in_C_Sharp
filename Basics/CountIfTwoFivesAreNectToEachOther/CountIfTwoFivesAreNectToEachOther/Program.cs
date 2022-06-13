using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new[] {5,5,2} ));
            Console.WriteLine(solution(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(solution(new[] { 5, 6, 2, 9 }));
            Console.ReadLine();
        }
        public static int solution(int[] numbers)
        {
            int result = 0;
            for(int i=0;i<numbers.Length-1; i++)
            {
                if (numbers[i] == 5)
                {
                    if (numbers[i + 1] == 5 || numbers[i+1] == 6)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}