using System.Drawing;



public class Square: Shape {
    public Square(string color, double side) : base(color){

        _side =side;
    }

    private double _side = 0;

public double Getside(){

        return _side;

    }
    public void Setside(double side) {

        _side = side;}
    public override double GetArea()
    {
        return _side * _side;
        
    }
}