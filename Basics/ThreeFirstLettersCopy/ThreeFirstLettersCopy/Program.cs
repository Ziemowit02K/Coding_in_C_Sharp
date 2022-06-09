using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("Python",2));
            Console.WriteLine(Solution("Python", 3));
            Console.WriteLine(Solution("JS", 3));
            Console.ReadLine();
        }
        public static string Solution(string str,int i)
        {
            string result = string.Empty;
            int frontOfTheString = 3;

            if (frontOfTheString > str.Length) 
                frontOfTheString = str.Length;

            string front = str.Substring(0,frontOfTheString);

            for (int n = 0; n < i; n++)
            {
                result += front;
            }
            return result;

            

        }
    }
}