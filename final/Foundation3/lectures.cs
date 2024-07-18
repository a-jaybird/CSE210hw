public class Lectures: Events{
    private string speaker;
    private string seatingCapacity;
    public Lectures(){
        eventType ="Lecture";
    }

      public string GetSpeaker(){
        return speaker;
    }
    public void SetSpeaker(string speaks){
       speaker = speaks;
    }
      public string GetSeating(){
        return seatingCapacity;
    }
    public void SetSeating(string seats){
        seatingCapacity = seats;
    }

    public string LectureFull(){
        return $"{Title} \n Speaker: {speaker} \nSummary:{description} \nDate: {date} \nevent start: {Time} \n seating limit: {seatingCapacity}";
    }
}