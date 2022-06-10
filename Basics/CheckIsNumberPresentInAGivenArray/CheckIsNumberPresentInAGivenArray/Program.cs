using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1,2,9,3,3));
            Console.WriteLine(solution(1,2,2,3,2));
            Console.WriteLine(solution(1,2,2,3,9));
            Console.ReadLine();
        }
        public static bool solution(int i1,int i2,int i3,int i4, int x)
        {
            int[] numbers = new int[] {i1,i2,i3,i4};
            if (numbers.Contains(x))
            {
                return true;
            }
            return false;
        }
    }
}