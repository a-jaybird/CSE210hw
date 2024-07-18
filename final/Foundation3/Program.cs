using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Outdoors a =new Outdoors();
        Address a1 =new Address();
        a.SetDate("October 18, 2024");
        a.SetTime("8am-3pm");
        a.SetTitle("56th Mesquite Fest");
        a.SetDescription("Come join our town as we celebrate the Mesquite wood and it many uses!"+
        " Jewelry, furniture, many many more!");
        a.SetWeather("sunny skies expected, but the event will have cover if weather changes.");
        a1.SetStreetName("45 Center St");
        a1.SetCity("Fredricksburg");
        a1.SetState("TX");
        Console.WriteLine(a.StandardDetails());
         Console.WriteLine(a.OutdoorFull());
         Console.WriteLine("Location: "+a1.FullAddress());
        Console.WriteLine(a.ShortDetails());

        Lectures b = new Lectures();
        b.SetDate("March 6, 2025");
        b.SetTime("12:00pm");
        b.SetSeating("250");
        b.SetSpeaker("Jon BytheWay");
        b.SetTitle("What are you carrying in Your Backpack");
        b.SetDescription("Do you wonder why life is so hard and how to make it better?"+
         "Come listen to our guest speaker and gain great spiritual insight!");
         Address b1 = new Address();
         b1.SetStreetName("1847 Pioneer Ave");
         b1.SetCity("Provo");
        b1.SetState("Utah");
        Console.WriteLine(b.StandardDetails());
         Console.WriteLine(b.LectureFull());
         Console.WriteLine("Location: "+b1.FullAddress());
        Console.WriteLine(b.ShortDetails());


        Receptions c = new Receptions();
        Address c1 = new Address();
        c.SetDate("December 9, 2024");
        c.SetTime("6pm-10pm");
        c.SetTitle("Kinder Wedding Reception");
        c.SetDescription("Please come give congratulations as Adrian Kinder and Kim Lowell join eachother in holy matrimony. ");
        c.SetContact("yourrsvp@aol.com");
        c1.SetStreetName("4518 Mulberry br");
        c1.SetCity("Afton");
        c1.SetState("WY");
        Console.WriteLine(c.StandardDetails());
        Console.WriteLine(c.ReceptionFull());
        Console.WriteLine("Location: "+c1.FullAddress());
        Console.WriteLine(c.ShortDetails());



}
}