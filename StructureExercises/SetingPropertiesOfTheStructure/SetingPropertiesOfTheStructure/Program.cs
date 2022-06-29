using System;
namespace Exercises
{
    class Program
    {
        struct newStruct
        {
            private int num;

            public int n
            {
                get 
                {
                    return num;
                }
                set 
                {
                    if(value<50)
                    num = value; 
                }
            }
            public void clsMethod()
            {
                Console.WriteLine("The stored value is: {0}",num);
            }
        }
        class strucExercises
        {
            public static void Main()
            {
                Console.WriteLine("Declares a structure with a property, a method and a private field: ");
                newStruct Example = new newStruct();
                Example.n = 15;
                Example.clsMethod();
            }
        }
    }

}