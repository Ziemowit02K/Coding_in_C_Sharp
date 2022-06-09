using System;

namespace exercises 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(solution("C Sharp"));
            Console.WriteLine(solution("JS"));
            Console.WriteLine(solution("a"));
            Console.ReadLine();
        }
        public static string solution(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2) +" "+ str.Substring(0, 2) + " " + str.Substring(0, 2) + " " + str.Substring(0, 2);

            }
            return str;

        }
    }
}