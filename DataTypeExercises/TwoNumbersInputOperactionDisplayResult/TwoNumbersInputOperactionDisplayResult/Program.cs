// Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome! Here you can make simple calulations.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Firstly you need to input first number, then operation input like: (+,-,*,/)");
                    Console.WriteLine("Next insert second number and get your result :)");
                    Console.WriteLine("Press anything to go on");
                    Console.ReadKey();
                    Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
            Console.WriteLine("Insert first number: ");
                string firstNumber1 = Console.ReadLine();
            if(firstNumber1 == null || firstNumber1 == " " || firstNumber1 =="")
            {
                Console.Clear();
                Console.WriteLine("Its not a number");
                Console.ReadKey();


            }
            else 
            {
                int firstNumber = Convert.ToInt32(firstNumber1);
                Console.WriteLine(" ");
                Console.WriteLine("Insert sign of opperation: ");
                string operationInput = Console.ReadLine().ToString();
                Console.WriteLine(" ");
                Console.WriteLine("Insert second number: ");
                    string secondNumber1 = Console.ReadLine();
                Console.WriteLine(" ");
                if (secondNumber1 == null || secondNumber1 == " " || secondNumber1 == "")
                {
                    Console.Clear();
                    Console.WriteLine("Its not a number");
                    Console.ReadKey();


                }
                else
                {
                    int secondNumber = Convert.ToInt32(secondNumber1);
                    if (operationInput.Equals("+"))
                    {
                        int result = firstNumber + secondNumber;
                        Console.WriteLine(firstNumber + " " + operationInput + " " + secondNumber + " = " + result);
                    }
                    else if (operationInput.Equals("-"))
                    {
                        if (firstNumber > secondNumber)
                        {
                            int result = firstNumber - secondNumber;
                            Console.WriteLine(firstNumber + " " + operationInput + " " + secondNumber + " = " + result);
                        }
                        else
                        {
                            int result = secondNumber - firstNumber;
                            Console.WriteLine(secondNumber + " " + operationInput + " " + firstNumber + " = " + result);
                        }

                    }
                    else if (operationInput.Equals("*"))
                    {
                        int result = firstNumber * secondNumber;
                        Console.WriteLine(secondNumber + " " + operationInput + " " + firstNumber + " = " + result);
                    }
                    else if (operationInput.Equals("/"))
                    {
                        int result = firstNumber / secondNumber;
                        Console.WriteLine(secondNumber + " " + operationInput + " " + firstNumber + " = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input type");
                    }
                    Console.ReadLine();
                }
               
            }
            

                       
                    


        }
       /* public static bool IsItNumber(string str)
        {
            double number;
            if (double.TryParse(str, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       */

    }
}
