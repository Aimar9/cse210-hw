using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine();

        Fraction f = new Fraction();
        f.SetTop(3);
        f.SetBottom(8);
        Console.WriteLine($"Numerador: {f.GetTop()}");
        Console.WriteLine($"Denominador: {f.GetBottom()}");
        Console.WriteLine();

        Fraction a = new Fraction();
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());

        Fraction b = new Fraction(5);
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());

        Fraction c = new Fraction(3, 4);
        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());

        Fraction d = new Fraction(1, 3);
        Console.WriteLine(d.GetFractionString());
        Console.WriteLine(d.GetDecimalValue());
    }
}