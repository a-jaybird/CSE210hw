using System.Drawing;



public class Circle: Shape {

    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    

    double _radius= 0;

    public override double GetArea()
    {
        return(double) (_radius* Math.PI) ;
    }
}