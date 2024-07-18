using System.Linq.Expressions;

public class Biking: Activity{
   


    public Biking(float biking,float minutes ){
        speed =biking;
        exerciseMinutes = minutes;
        activityType ="Biking";
    }

    public override float GetSpeed(){

        
        return speed;
    }
    public override float GetDistance(){
       distance = (speed/60) * exerciseMinutes; 
    return distance;
}
public override float GetPace(){
    pace = 60/speed;
    return pace;
}
}