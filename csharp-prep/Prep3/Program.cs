using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int answer = 9;
        
        Console.WriteLine("Betcha can't guess my number:");
        string guess = Console.ReadLine();
        int number = int.Parse(guess);
        
        do{
                
            if (number < answer)
            {
                Console.WriteLine("too low; guess again:");
                
        
                

            }
            else if(number > answer)
            {
                Console.WriteLine("too high; guess again:");

            }

            guess = Console.ReadLine();
            number = int.Parse(guess);
        
        }while(number != answer);
        
        Console.WriteLine("Congrats, you got it!");
           
            
            

        
    }
}