using System;
namespace exercises
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test("xy"));
            Console.ReadLine();
        }
        public static string test(string str)
        {
            if (str.Length > 1)
            {
                return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);

            }
            else 
            {
                return str;
            }
           
        }
    }
}