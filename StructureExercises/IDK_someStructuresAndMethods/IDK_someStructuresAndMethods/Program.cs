using System;
public struct sampStru
{
    private double val;
    public double Value
    {
        get { return val; }
        set { val = value; }
    }
    public double Read()
    {
        return double.Parse(Console.ReadLine());
    }
    public struct Square
    {
        sampStru ln;
        sampStru ht;
        public sampStru Length
        {
            get { return ln; }
            set {ln = value;}
        }
        public sampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }
        public void newSquare()
        {
            sampStru rct = new sampStru();

            Console.WriteLine("Input the dimension of the Square (equals lenght and breadth): ");
            ln = sqrLength();
            Console.Write("Breadth: ");
            ht.Value = rct.Read();
        }
        public sampStru sqrLength()
        {
            sampStru rct = new sampStru();

            Console.Write("Length: ");
            rct.Value = rct.Read();
            return rct;
        }

    }
    public class Exercises
    {
        static void Main()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            Console.Write("--------------------------------------\n");
            var Sqre = new Square();
            Sqre.newSquare();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}
