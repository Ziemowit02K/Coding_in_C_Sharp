using System;
namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("abcdsab"));
            Console.WriteLine(solution("abcdabab"));
            Console.WriteLine(solution("abcabdabab"));
            Console.WriteLine(solution("abcabd"));
            Console.ReadLine();
        }
        public static string solution(string str)
        {
            string last_two_chars = str.Substring(str.Length-2);
            int count = 0;

            for(int i = 0; i < str.Length-2; i++)
            {
                if (str.Substring(i, 2).Equals(last_two_chars)) count++;
            }
            return count.ToString();

        }
    }
}