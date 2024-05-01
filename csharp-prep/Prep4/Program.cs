using System;

class Program
{
    static void Main(string[] args)
    {
      List<int> numbers;
      numbers=new List<int>();
       Console.WriteLine("put in a number");
       int max = 0;
        int total = 0;
        string input = Console.ReadLine();
        int number = int.Parse(input);
        while ( number!= 0)
        {   
            Console.WriteLine("put in a number");
            numbers.Add(number);
            input = Console.ReadLine();
            number = int.Parse(input);
            
            
        }
        foreach ( int num in numbers){
            
            total += num;
            if (max < num){
                max = num;
            } 

        }

        {
            Console.WriteLine($"the total of the list would be: {total}");
            Console.WriteLine($"the average would be: {total/numbers.Count}");
            Console.WriteLine($"The largest number in the list is: {max}");
        }
    }
}