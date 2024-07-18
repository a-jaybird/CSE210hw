public abstract class Activity{
protected string date;
protected float exerciseMinutes;
 protected float speed;
 protected float distance;
 protected float pace;
 protected string activityType;

// public Activity(string day){
//     date = day;
 
// }
public void SetDate(string day){
    date = day;
}
public virtual float GetSpeed(){

    return speed;
}
public virtual float GetDistance(){
    return distance;
}

public virtual float GetPace(){
    return pace;
}

public string GetSummary(){
 return $"{date} {activityType} ({exerciseMinutes} minutes)- Distance: {distance} miles, Speed:{speed} mph, Pace: {pace} min per mile.";
}

}