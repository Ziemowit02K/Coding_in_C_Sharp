using System;
namespace exercises
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine(solution("Red"));
            Console.WriteLine(solution("Green"));
            Console.WriteLine(solution("1"));
            Console.ReadLine();
        }

        public static string solution(string str) 
        {
            if (str.Length >= 1) 
            {
                return  str.Substring(str.Length - 1) + str.Substring(0,1) + str.Substring(1, str.Length-1) + str.Substring(str.Length-1);
            }
            return str;
        }
    }
}