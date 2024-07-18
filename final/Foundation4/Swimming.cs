

public class Swimming : Activity{
    protected float LapsSwam;

public Swimming(float swam,float minutes){
    LapsSwam =swam;
    exerciseMinutes =minutes;
    activityType ="Swimming";
}

    public override float  GetDistance(){

        distance = (LapsSwam*50) /1000;        
        return distance;

    } 
    public override float GetSpeed(){
      speed = (distance/exerciseMinutes)* 60;

    return speed;
}
public override float GetPace(){
    pace = 60/speed;

    return pace;
}
}