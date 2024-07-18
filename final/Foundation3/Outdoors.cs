public class Outdoors: Events{

    private string weatherTracker;
   public Outdoors(){
    eventType= "Outdoors";
   }

    public string GetWeather(){
        return weatherTracker;
    }
    public void SetWeather(string weather){
        weatherTracker =weather;
    }

    public string OutdoorFull(){
        return $"{Title} \n Summary: {description} \nDate: {date} \nevent start: {Time} \n{weatherTracker}";
    }
    
}