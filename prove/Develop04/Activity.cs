using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Activity{
   protected int timer;   
    protected string act = "";
    protected string desc = "";
    
    List<string> animated ; 

    public Activity(){
        animated =new List<string>();
        animated.Add("|");
        animated.Add("/");
        animated.Add("-");
        animated.Add("\\");
       
        
    }
   public void startActivity(){

      Console.WriteLine($"Welcome to the {act}.{desc} In seconds,how long do you want to do this activity?");

       
        string time= Console.ReadLine();
        timer=int.Parse(time);
    
    //    for(int x = timer; x> 0; x--) {

    //     Console.Write('+');
    //     Thread.Sleep(1000);
    //     Console.Write("\b \b");
    //     Console.Write("-");

    //     }
    }
    public void endActivity(){
        Console.WriteLine($"Good job!Thank you for doing this {act}. This session lasted {timer} seconds.");
        Thread.Sleep(4000);
        
    }
    public void animatedWait(int stop){
        for(int x = 0; x<stop; x++) {
            Console.Write(animated[x % animated.Count()]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
           

        }
    }

    public void countDown(){
        // for(int x = tick; x> 0; x--) {
        // }
        
        for(int y= 5; y>0; y-- ){

            Console.Write(y);
            Thread.Sleep(1000);
            Console.Write("\b \b");


        }
        
    }
}


    