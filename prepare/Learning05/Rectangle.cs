using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;


public class Rectangle : Shape{
 public Rectangle(string color, double length, double width) : base(color){
        _length = length;
        _width = width;
 }
    double _length = 0;
    double _width = 0;
public double GetsideX(){

        return _length;

    }
    public void SetsideX(double length){

        _length =length;
        }
public double GetWidth(){


        return _width;
    }
    public void SetWidth(double width){

        _width = width;}
    public override double GetArea()
    {
        return  _length * _width;
        
    }

}