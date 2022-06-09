using System;
namespace exercises
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("Python"));
            Console.WriteLine(solution("JS"));
            Console.WriteLine(solution("Code"));
        }
        public static string solution(string str)
        {
            if (str.Length > 3)
            {
                return str.Substring(0, 3) + str + str.Substring(0, 3);
            }
            else
            {
                return str.Substring(0, str.Length) + str.Substring(0, str.Length) + str.Substring(0, str.Length);
            }
            
        }
    }
}