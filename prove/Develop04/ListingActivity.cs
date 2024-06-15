using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity: Activity{
    List<string>prompts;
    Random rnd = new Random();

    public ListingActivity(){
        act ="Listing Activity";
        desc ="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
    
  
    }
    public void doList(){
        Console.WriteLine(askPrompt());
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.ReadLine();
            currentTime = DateTime.Now;
        }   
    }
    public string askPrompt(){
             int r = rnd.Next(prompts.Count);
            return prompts[r];
        }

}