using System;
using System.Linq;

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
        public static int solution(string str, string str1)
        {
            int result = 0;
            for(int i=0; i < str.Length - 1; i++)
            {
                var firstString = str.Substring(i, 2);
                for(var j=0;j<str1.Length-1; j++)
                {
                    var secondString = str1.Substring(j, 2);
                    if (firstString.Equals(secondString))
                    {
                        result++;
                    }

                }

            }
            return result;
        }
    }
}