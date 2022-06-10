using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("Python"));
            Console.WriteLine(solution("PHP"));
            Console.WriteLine(solution("JS"));
            Console.ReadLine();
        }
        public static string solution(string str)
        {
            string result = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += str[i];
                }
               
            }
            return result;

        }
    }
}