using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("caabb"));
            Console.WriteLine(solution("babaaba"));
            Console.WriteLine(solution("aaaaa"));
            Console.ReadLine();
        }
        public static bool solution(string str)
        {
            int count = 0;
            for(int i=0;i<str.Length-1; i++)
            {
                if (str[i].Equals('a'))
                {
                    count++;
                    if (str.Substring(i,2).Equals("aa") && count<2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}