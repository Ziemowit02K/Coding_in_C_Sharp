// Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol
using System;
namespace exercise
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input a symbol: ");
            string symbol = Console.ReadLine();
            if (IsItLowercaseVowel(symbol))
            {
                Console.WriteLine(symbol + " is a lowercase vowel ");
                Console.ReadKey();
            }
            else
            {
                if (IsItDigit(symbol))
                {
                    Console.WriteLine(symbol + " is a digit");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("It's another symbol");
                    Console.ReadKey();
                }
            }
        }
        public static bool IsItLowercaseVowel(string str1)
        {
            string str = str1.ToLower();
            if(str=="a" || str == "e" || str == "i" || str == "o" || str == "u")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsItDigit(string str)
        {
            int i = 0;
            if (int.TryParse(str, out i))
                {
                if (i >= 0 && i <= 9)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
