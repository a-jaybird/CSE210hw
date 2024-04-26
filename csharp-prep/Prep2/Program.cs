using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your score? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
       
       
       if (number < 70){
        Console.Write("Try harder next time");

         if (number < 59)
            {
            Console.Write(" You got an F");

            }
         else if(number < 69 )
            {
             Console.Write(" You got a D");
  
            
            }  
       }  
        if(number > 70)
        {
            Console.Write("Congrats, you passed!");

            if (number > 70 && number < 80)
            {
                Console.Write(" You got a C");

            }
    
            else if(number < 90 && number> 79)
            {
            Console.Write(" You got a B");

            }
            else
            {
            Console.Write(" You got an A");

            }
        

        
        // Console.WriteLine("Hello Prep2 World!");
        }
    }
}
// IF, ELSE, ELSE IF
// if (x > y)
// {
//     Console.WriteLine("greater than y");
// }
// else if (x > z)
// {
//     Console.WriteLine("greater than z");
// }
// else
// {
//     Console.WriteLine("less than both");
// }

// And,OR,NOT OPERATORS
// if (name == "Peter" || name == "James" || name == "John")
// {
//     Console.WriteLine("This is a biblical name.");
// }

// if (firstName == "Brigham" && lastName == "Young")
// {
//     Console.WriteLine("Welcome Brother Brigham!");
// }

// if (!(name == "Peter" || name == "James" || name == "John"))
// {
//     Console.WriteLine("This is a not one of those three");
// }