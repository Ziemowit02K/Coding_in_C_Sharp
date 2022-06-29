using System;
namespace exercises
{
    class newClass
    {
        public int n;
    }
    struct newStruct
    {
        public int n;
    }
    class strucExercises
    {
        public static void trackStruct(newStruct st)
        {
            st.n = 8;
        }
        public static void tracClass(newClass cl)
        {
            cl.n = 8;
        }
        public static void Main()
        {
            Console.WriteLine("When a structure and a class instance is passed to a method");
            Console.WriteLine();
            newStruct ns =new newStruct();
            newClass nc = new newClass();
            ns.n = 5;
            nc.n = 5;

            trackStruct(ns);
            tracClass(nc);
            Console.WriteLine("ns.n={0}",ns.n);
            Console.WriteLine("nc.n={0}",nc.n);
        }
    }
}