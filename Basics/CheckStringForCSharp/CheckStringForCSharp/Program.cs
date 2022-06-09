using System;
namespace exercise 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(solution("C# Sharp"));
            Console.WriteLine(solution("C#"));
            Console.WriteLine(solution("C++"));
            Console.ReadLine();

        }
        public static bool solution(string str) 
        {
            return (str.Length<3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }
    }
}