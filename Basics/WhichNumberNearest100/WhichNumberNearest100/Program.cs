using System;
namespace exerxise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(78,95));
            Console.WriteLine(solution(95,95));
            Console.WriteLine(solution(99,70));
            Console.ReadLine();
        }
        public static string solution(int i1, int i2)
        {
            int DifferenceI1 = 100 - i1;
            int DifferenceI2 = 100 - i2;

            if (DifferenceI1 < DifferenceI2)
            {
                return i1.ToString();
            }
            else if(DifferenceI2 < DifferenceI1)
            {
                return i2.ToString();
            }
            else
            {
                return 0.ToString();
            }


        }
    }
}