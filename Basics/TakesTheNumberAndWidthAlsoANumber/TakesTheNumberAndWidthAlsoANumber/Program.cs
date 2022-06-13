//  Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            int NumberGiven;
            int WidthGiven;
            Console.WriteLine("Podaj numer do wyświetlenia: ");
                NumberGiven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj szerokość: ");
                WidthGiven = Convert.ToInt32(Console.ReadLine());

            int Width = WidthGiven;
            int Height = Width;
            

            for (int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    Console.Write(NumberGiven);
                    
                }
                Width--;
                Console.WriteLine();
            }



            Console.ReadKey();
        }

            
        }
    }

