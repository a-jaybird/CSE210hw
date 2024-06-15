

public class ReflectionActivity: Activity{
    
    List<string> firstPrompts;
    List<string>secondPrompts;
     Random rnd = new Random();
    public ReflectionActivity(){
        act ="Reflection Activity";
        desc ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    
        firstPrompts = new List<string>();
        firstPrompts.Add("Think of a time when you stood up for someone else.");    
        firstPrompts.Add("Think of a time when you did something really difficult.");
        firstPrompts.Add("Think of a time when you helped someone in need.");
        firstPrompts.Add("Think of a time when you did something truly selfless");

        secondPrompts = new List<string>();
        secondPrompts.Add("Why was this experience meaningful to you?");
        secondPrompts.Add("Have you ever done anything like this before?");
        secondPrompts.Add("How did you get started?");
        secondPrompts.Add("How did you feel when it was complete?");
        secondPrompts.Add("What made this time different than other times when you were not as successful?");
        secondPrompts.Add("What is your favorite thing about this experience?");
        secondPrompts.Add("What could you learn from this experience that applies to other situations?");
        secondPrompts.Add("What did you learn about yourself through this experience?");
        secondPrompts.Add("How can you keep this experience in mind in the future?");
    }
     public void Reflect(){
        Console.Write(beginReflect());
        Console.ReadLine();
        for(int x =timer; x>0; ){
             Console.WriteLine(midPrompt());
            animatedWait(7);
            x-=7;    
        }

    }
    public string beginReflect(){
        
       
        int r = rnd.Next(firstPrompts.Count);
        return firstPrompts[r];
    }
    public string midPrompt(){
        int r = rnd.Next(secondPrompts.Count);
        return secondPrompts[r];
    }
   
    
}