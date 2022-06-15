// Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, you need to insert your 'x' and number of series");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insert X:  ");
            string XGiven = Console.ReadLine();
            Console.Write("Insert number of series:  ");
            string numberGiven = Console.ReadLine();
            if (IsItNumber(numberGiven) && IsItNumber(XGiven))
            {
                double number = Convert.ToInt32(numberGiven);
                int x = Convert.ToInt32(XGiven);
                int multipler = 2;
                //int multipler3 = 4;
                //double multipler2 = (x*x);
                double n = 1;
                double factional = 2;
                double model = (n - (x ^ multipler) / (factional) +((x^ multipler* multipler) /factional* factional));
                //double model = (n - (multipler2) / (factional) +((multipler2*multipler2) /factional*factional));
                double sum = 0;
                

                for(int i = 0; i <= number+2; i++)
                {
                    model = (n - (x ^ multipler) / (factional) + ((x ^ multipler * multipler) / factional * factional));
                    //multipler2 *= multiplerer2;
                    Console.WriteLine("Wzrór:  "+model);
                    sum =sum + model;
                    Console.WriteLine("Suma:  " + sum);
                   
                    n = 0;
                    /*for(int f=0;f<number; f++)
                    {
                        factional *= factional;
                    }
                        
                        multipler *= multipler;*/
                        Console.WriteLine(model);
                    

                }
                //Console.Clear();
                Console.WriteLine("The sum: {0}",sum);
                Console.WriteLine();
                Console.WriteLine("Number of terms = {0}",number);
                Console.WriteLine("Value of x: {0}",x);
                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong Input");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            int i;
            if (int.TryParse(str, out i))
            {
                return true;
            }
            return false;

        }
    }
}

