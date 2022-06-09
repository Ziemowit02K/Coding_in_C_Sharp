using System;
namespace exercise
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine(solution("Python"));
            Console.WriteLine(solution("ytade"));
            Console.WriteLine(solution("jsues"));

        }
        public static string solution(string str)
        {
            if (str.Substring(1, 2).Equals("yt"))
            {
                return str.Remove(1, 2);
                
            }
            return str;
        }
    }
}