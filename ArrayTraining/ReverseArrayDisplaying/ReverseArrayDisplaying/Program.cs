//Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
namespace exercises
{
    class Project
    {
        static void Main()
        {
            int i;
            string n;
            Welcome();

            Console.Write("Insert number of arrays: ");
            string numberGiven = Console.ReadLine();

            if (IsItNumber(numberGiven))
            {
                int numbers = Convert.ToInt32(numberGiven);
                int[] storage = new int[numbers];
                Console.WriteLine("Input {0} elements of an array: ", numbers);
                for (i = 0; i < numbers; i++)
                {
                    Console.Write("element - {0}: ", i+1);
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
                Console.WriteLine("Elements in array are: ");
                for (i = 0; i < numbers; i++)
                {
                    Console.WriteLine("Element {0}: {1}", i+1, storage[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Reversed elements in array are: ");
                for (i = numbers-1; i >= 0; i--)
                {
                    Console.WriteLine("Element {0}: {1}",i+1,storage[i]);
                }
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
            Console.WriteLine("               Today I am gonna display you your array in REVERSE         ");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
