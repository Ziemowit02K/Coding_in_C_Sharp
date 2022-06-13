// Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("FizzBuzz"));
            Console.WriteLine(solution("Fizz"));
            Console.WriteLine(solution("Buzz"));
            Console.WriteLine(solution("Founder"));
        }
        public static string solution(string str)
        {
            string FirstLetter = str.Substring(0, 1);
            if(FirstLetter.Equals("F") && str.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (FirstLetter.Equals("F") && !(str.EndsWith("B")))
            {
                return "Fizz";
            }
            else if (str.EndsWith("B") && !(FirstLetter.Equals("F")))
            {
                return "Buzz";
            }
            else
            {
                return str;
            }
        }
    }
}
