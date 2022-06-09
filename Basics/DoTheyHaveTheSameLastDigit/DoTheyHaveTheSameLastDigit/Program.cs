using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("123", "456"));
            Console.WriteLine(solution("12", "512"));
            Console.WriteLine(solution("7", "87"));
            Console.WriteLine(solution("12", "45"));
            Console.ReadLine();
        }

        public static string solution(string i1, string i2)
        {
            if (int.Parse(i1) >= 0 && int.Parse(i2) >= 0) 
            {
               if(i1.Substring(i1.Length-1) == i2.Substring(i2.Length-1)) 
               {
                    return "True";
               }
            }
            return "False";
        }
    }
}