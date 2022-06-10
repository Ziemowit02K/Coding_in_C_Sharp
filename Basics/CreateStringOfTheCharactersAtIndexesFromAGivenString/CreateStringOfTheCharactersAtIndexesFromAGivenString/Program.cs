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
            Console.ReadLine();
        }
        public static string solution(string str)
        {
            string result = string.Empty;
            for(int i=0; i <str.Length; i+=4)
            {
                int x = i + 2;
                int n = 0;
                n += x > str.Length ? 1 : 2;
                result += str.Substring(i, n);
               
            }
            return result;
        }
    }
}