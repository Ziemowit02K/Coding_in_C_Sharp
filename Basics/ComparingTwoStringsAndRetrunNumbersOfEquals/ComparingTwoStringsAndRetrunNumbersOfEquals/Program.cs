using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("abcdefgh", "abijsklm"));
            Console.WriteLine(solution("abcde", "osuefrcd"));
            Console.WriteLine(solution("pqrstuvwx", "pqkdiewx"));
            Console.ReadLine();
        }
        public static int solution(string str1, string str2)
        {
            int count = 0;
            for(int i = 0; i < str1.Length - 1; i++)
            {
                string stringFirst = str1.Substring(i, 2);
                for(int j=0; j < str2.Length - 1; j++)
                {
                    string stringSecound = str2.Substring(j, 2);
                    if (stringFirst.Equals(stringSecound)) count++;
                }  
            }
            return count;
        }
    }
}