using System;
namespace exercises

{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(120, -1));
            Console.WriteLine(solution(-1, 120));
            Console.WriteLine(solution(2, 120));
            Console.ReadLine();
        }
        public static bool solution(int Temp1, int Temp2)
        {
            return Temp1 < 0 && Temp2 > 100 || Temp2 < 0 && Temp1 > 100;
        }
    }
}