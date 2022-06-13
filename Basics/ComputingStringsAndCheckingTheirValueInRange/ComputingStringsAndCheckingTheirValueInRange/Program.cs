// Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(3, 7));
            Console.WriteLine(solution(10, 11));
            Console.WriteLine(solution(10, 20));
            Console.WriteLine(solution(21, 220));
            Console.ReadLine();
        }
        public static int solution(int i1, int i2)
        {
            int i3 = i1 + i2;
            if((i1>=10 && i1<=20) || (i2>=10&& i2 <= 20))
            {
                return 18;
            }
            return i3;
        }
    }
}
