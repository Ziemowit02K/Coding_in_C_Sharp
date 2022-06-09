using System;
namespace exercises 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("Python"));
            Console.WriteLine(solution("Javascript"));
            Console.WriteLine(solution("js"));
            Console.WriteLine(solution("PHP"));
            Console.ReadLine();
        }
        public static string solution(string str)
        {
            if (str.Length > 3)
            {
                str.ToUpper();
                return str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
            else
            {
                return str.ToUpper();

            }
        }
    }
}