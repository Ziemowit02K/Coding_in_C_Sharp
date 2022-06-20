//Write a program in C# Sharp to copy the elements one array into another array
namespace exercises
{
    class Project
    {
        static void Main()
        {
            int i;
            string n;
            Welcome();

            Console.Write("Insert lenght of array: ");
            string numberGiven = Console.ReadLine();

            if (IsItNumber(numberGiven))
            {
                int numbers = Convert.ToInt32(numberGiven);
                int[] storage = new int[numbers];
                Console.WriteLine("Input {0} elements of an array: ", numbers);
                for (i = 0; i < numbers; i++)
                {
                    Console.Write("element - {0}: ", i + 1);
                    if (IsItNumber(n = Console.ReadLine()))
                    {
                        int element = Convert.ToInt32(n);
                        storage[i] = element;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }

                }
                Console.WriteLine();
                Console.WriteLine("--- --- --- Press any key to continue --- --- ---");
                Console.ReadKey();
                Console.Clear();
                int sum=0;
                for(i=0;i<numbers; i++)
                {
                    sum += storage[i];
                }
                Console.WriteLine("Sum of all elements stored in the array is: {0} ", sum);
                
                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            if (int.TryParse(str, out int i))
            {
                return true;
            }
            return false;
        }
        public static void Welcome()
        {
            Console.WriteLine("                     --- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("               Today I am gonna display you truth         ");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
