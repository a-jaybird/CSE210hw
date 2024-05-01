using System;

class Program
{
    static void Main(string[] args)
    
    {
        DisplayWelcome();
        string username = PromptUserName();
        int numb = PromptUserNumber();
        int square = SquareNumber();
        DisplayResult(username,square);
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

    }
    static string PromptUserName()
    {
        Console.WriteLine("What's your name?");
       string name =Console.ReadLine();
       return name;
    }
    static int PromptUserNumber( )
    {
         Console.WriteLine("What's your favorite number?");
         string number =Console.ReadLine();
         int favoritenumber = int.Parse(number);
         return favoritenumber;

    }
    static int SquareNumber() 
    {
        Console.WriteLine("Gimme a number:");
        string prompt = Console.ReadLine();
        int number =int.Parse(prompt);
        int squared = number * number;

       return squared;
    }
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");

    }






}
