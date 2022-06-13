//  Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login , password;
            int Tryes = 3;
            do
            {
                Console.WriteLine("Enter yout UserID: ");
                Login = Console.ReadLine();
                Console.WriteLine("Enter yout Password: ");
                password = Console.ReadLine();
                if (Login == "root" && password == "1234")
                {
                    Tryes--;
                    Console.WriteLine("");
                    Console.WriteLine("Welcome");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                }
                else
                {
                    
                    Tryes--;
                    if (Tryes == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You were rejected, try again later");
                        Console.WriteLine("");
                        Console.WriteLine("Click anything to continue");
                        Console.ReadKey();
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Try again");
                    Console.WriteLine();
                }
            }
            while (Tryes > 0);
        }
    }
}
