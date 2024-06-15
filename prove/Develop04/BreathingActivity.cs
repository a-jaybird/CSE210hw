

public class BreathingActivity: Activity {

public BreathingActivity(){
    act = "Breathing Activty";
    desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    


} 
public void Breathing(){
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(timer);
    while(DateTime.Now < futureTime){

        Console.WriteLine("breathe in...");    
        countDown();
        Console.WriteLine("breathe out...");
        countDown();
    }
        

}
}