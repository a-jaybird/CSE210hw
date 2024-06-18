using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Shape{
private  string _color= "";
double Area =0;
    public Shape(string color){

        _color = color;
    //   private  string _color= "";
    }

    public string GetColor(){

        return _color;

    }
    public void SetColor(string color){

        _color =color;

    }


    public virtual double GetArea(){
        return  Area;
    }
        
       } 