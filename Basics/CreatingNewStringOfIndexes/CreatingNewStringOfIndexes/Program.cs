using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("Python"));
            Console.WriteLine(solution("JavaScript"));
            Console.WriteLine(solution("HTML"));
        }
        public static string solution(string str)
        {
            string str1 = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if(i==0 || i == 1 || i == 4 || i == 5 || i == 8 || i == 9)
                {
                    str1 += str[i];
                }
            }
            return str1;
        }
    }
}