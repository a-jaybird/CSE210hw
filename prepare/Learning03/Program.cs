using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // stuff starts in here
          Fraction first = new Fraction();
          Console.WriteLine(first.GetFractionString());
          Console.WriteLine(first.GetDecimalValue());

        Fraction second = new Fraction(5);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


         





        }
        
    
}