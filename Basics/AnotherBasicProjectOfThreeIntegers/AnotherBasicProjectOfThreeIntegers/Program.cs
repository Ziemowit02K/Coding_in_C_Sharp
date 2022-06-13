// Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1,2,3));
            Console.WriteLine(solution(4,5,6));
            Console.WriteLine(solution(-1,1,0));
            Console.ReadLine();
        }
        public static string solution(int x,int y,int z)
        {
            if(y > x && z > y)
            {
                return "True";
            }
            return "False";
        }
    }
}
