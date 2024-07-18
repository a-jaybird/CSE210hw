public class Running : Activity{
    
     
    public Running(float ran,float minutes){
        distance = ran;
        exerciseMinutes = minutes;
        activityType ="Running";
    }
    public override float GetDistance(){
        

        return distance;
    }
    public override float GetSpeed(){
      speed =  (distance / exerciseMinutes)*60; 

    return speed;
}
public override float GetPace(){
    pace = 60/speed;
    return pace;
}
}