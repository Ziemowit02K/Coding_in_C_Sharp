using System;
namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("frizz"));
            Console.WriteLine(solution("zane"));
            Console.WriteLine(solution("Zazz"));
            Console.WriteLine(solution("false"));
            Console.WriteLine(solution("zzzz"));
            Console.WriteLine(solution("ZZZZ"));
            Console.ReadLine();
        }
        public static string solution(string str)
        {
            if (str.Substring(2) == "z" || str.Substring(3) == "z" || str.Substring(4) == "z") 
            {
                return "True";
            }
            return "False";
        }
    }
}