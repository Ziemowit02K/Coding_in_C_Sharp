using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("xxHxix", "x"));
            Console.WriteLine(solution("abxdddca", "a"));
            Console.WriteLine(solution("xabjbhtrb", "b"));
            Console.ReadLine();
        }
        public static string solution(string str, string unWanted)
        {
           
            for(int i = str.Length-2; i > 0; i--)
            {
                if (str[i] == unWanted[0])
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }
    }
}