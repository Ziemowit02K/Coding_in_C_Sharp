using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("bbaaccaag"));
            Console.WriteLine(solution("jjkiaaasew"));
            Console.WriteLine(solution("JSaaakoiaa"));
            Console.ReadLine();
        }

        public static string solution(string str)
        {
            int count = 0;
            for(int i =0; i < str.Length - 1; i++)
            {
                if(str.Substring(i, 2) == "aa")
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}