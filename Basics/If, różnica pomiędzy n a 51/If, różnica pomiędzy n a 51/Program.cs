
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj 3 cyfry");

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

if (n1 > 51)
{
    int n1D = (n1 - 51) * 3;
    Console.WriteLine(n1D);

}
else
{
    int n1D = 51-n1;
    Console.WriteLine(n1D);
}

if (n2 > 51)
{
    int n2D = (n2 - 51) * 3;
    Console.WriteLine(n2D);

}
else
{
    int n2D = 51 - n2;
    Console.WriteLine(n2D);
}

if (n3 > 51)
{
    int n3D = (n3 - 51) * 3;
    Console.WriteLine(n3D);

}
else
{
    int n3D = 51 - n3;
    Console.WriteLine(n3D);
}





Console.ReadKey();