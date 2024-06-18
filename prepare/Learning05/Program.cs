using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red",5.0));
        shapes.Add(new Circle("yellow", 10.0));
        shapes.Add(new Rectangle("blue",7.0,6.0));

        foreach(Shape shapex in shapes){
            Console.WriteLine(shapex.GetColor());
            Console.WriteLine(shapex.GetArea());
        }
    }
      
       
}