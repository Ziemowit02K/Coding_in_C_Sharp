using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("abcd"));
            Console.WriteLine(solution("abc"));
            Console.WriteLine(solution("a"));
            Console.ReadLine();

        }
        public static string solution(string str)
        {
            string result = string.Empty;

            for(int i = 0; i<str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }
    }
}
