using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        // 1st parameter laps, 2nd minutes
        Swimming a= new Swimming(20,20);
        a.SetDate("June 3 2024");
        a.GetDistance();//get distance first
        a.GetSpeed();
        a.GetPace();
        Console.WriteLine(a.GetSummary());

        Running b = new Running(5,30);
        b.SetDate("May 5 2024");
        b.GetSpeed();
        b.GetDistance();
        b.GetPace();
        Console.WriteLine(b.GetSummary());

        Biking c = new Biking(10, 85);
        c.SetDate("August 3 2024");
        c.GetDistance();
        c.GetSpeed();
        c.GetPace();
        Console.WriteLine(c.GetSummary());

    }
}   