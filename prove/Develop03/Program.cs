using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Here's a scripture to memorize; press enter to make more words disappear or type quit to end.");

        Scripture v = new Scripture();
    // string verse = v.Script();
    
        v.printVerse();

       string input = Console.ReadLine();
        while(input != "quit"){
        v.hideWord();
        v.printVerse();
        Console.WriteLine("Continue or type quit to end:");
        input = Console.ReadLine();
        }

    }
}