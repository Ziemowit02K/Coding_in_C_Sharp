using System;
namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(78,95));
            Console.WriteLine(solution(20,30));
            Console.WriteLine(solution(21,25));
            Console.WriteLine(solution(28,28));
            Console.ReadLine();
        }
        public static string solution(int i1, int i2)
        {
            if((i1>0 && i2>0) && ((i1>=20 && i1<=30) && (i2>=20 && i2 <= 30)))
            {
                if (i1 > i2)
                {
                    return i1.ToString();
                }
                else 
                {
                    return i2.ToString();
                }
            }
            return 0.ToString();
        }
    }
}