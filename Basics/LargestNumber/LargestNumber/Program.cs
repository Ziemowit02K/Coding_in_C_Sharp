using System;
namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1,2,3));
            Console.WriteLine(solution(1,3,2));
            Console.WriteLine(solution(1,1,1));
            Console.WriteLine(solution(1,2,2));
            Console.ReadLine();
        }
        public static string solution(int i1, int i2, int i3)
        {
            if (i1 > i2 && i1>i3)
            {
                return i1.ToString();

            }
            else if(i2>i3 && i2>i3)
            {
                return i2.ToString();
            }
            else
            {
                return i3.ToString();
            }
        }
    }
}
