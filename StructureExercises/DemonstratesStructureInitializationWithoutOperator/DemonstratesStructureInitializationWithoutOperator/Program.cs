using System;
namespace exercises
{
    public struct newStruct
    {
        public int m, n;
        public newStruct(int p1, int p2)
        {
            m = p1; n = p1;
        }
    }
    class StructureExercises
    {
        static void Main()
        {
            Console.WriteLine("Structure declares using default and parametrized construtors");
            Console.WriteLine();

            newStruct myPoint;
            myPoint.m = 30;
            myPoint.n = 40;

            Console.WriteLine("m = {0}, n = {1}",myPoint.m,myPoint.n);

            Console.ReadKey();

        }
    }
}