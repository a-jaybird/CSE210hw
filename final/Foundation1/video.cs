using System.Security.Cryptography.X509Certificates;

public class Video{

         public string title;
         public string Author;
         public int lengthSecs;
         public int numberOfComments;
    
    public void Display(){
        Console.WriteLine($"Movie title: {title} \nCreator: {Author} \nmovie length: {lengthSecs} \nComments: {numberOfComments}");
    }




}