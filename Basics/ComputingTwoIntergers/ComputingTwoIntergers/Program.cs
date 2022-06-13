// Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(12, 17));
            Console.WriteLine(solution(2, 17));
            Console.WriteLine(solution(22, 17));
            Console.WriteLine(solution(20, 0));
            Console.ReadLine();
        }
        public static int solution(int i1, int i2)
        {
            int i3 = i1 + i2;
            if(i3>=10 && i3 <= 20)
            {
                return 30;
            }
            else
            {
                return i3;
            }
            
        }

    }
}
