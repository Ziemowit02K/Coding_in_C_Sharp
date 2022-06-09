using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("JS",2));
            Console.WriteLine(solution("JS", 3));
            Console.WriteLine(solution("JS", 1));
        }
        public static string solution(string str,int n)
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}

