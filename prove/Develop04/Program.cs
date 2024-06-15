using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the Mindfulness program.");
        string answer ="";
        while(answer != "4"){
            Console.WriteLine("Please select an activity you'd like to start. \n"
            +"Type 1 for a Breathing Activity, 2 for the Listing Activity, or 3 for the Reflection Activity.\n"
        +"or type 4 to end.");
            answer= Console.ReadLine();
            if(answer == "1"){

                BreathingActivity a = new BreathingActivity();
                a.startActivity();
                Thread.Sleep(1000);
                a.Breathing();    
                a.animatedWait(5);
                a.endActivity();
            }
            else if(answer =="2"){

                ListingActivity b =new ListingActivity();
                
                b.startActivity(); 
                b.countDown();
                Thread.Sleep(1000);
                b.doList(); 
                b.animatedWait(5);
                b.endActivity();  

            }

            else if(answer=="3"){
                ReflectionActivity c =new ReflectionActivity();
                c.startActivity();
                Thread.Sleep(1000);
                c.Reflect();
                c.animatedWait(5);
                c.endActivity();

                

            }
        else{
            
            Console.Write("Goodbye. Thank you for participating.");
            Console.Write("O/");
            for (int n = 5; n > 0; n--){
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            } 
            
            return;
         }
        }
    }
}