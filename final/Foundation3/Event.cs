using System.Collections.Specialized;
using System.Diagnostics.Contracts;

public class Events{
    protected string Title;
    protected string description;
    protected string date;
    protected string Time;
    public string eventType;
    protected Address address;
public Events(){
     eventType="event";

}
    public string GetTitle(){
        return Title;
    }
    
    public void SetTitle(string title){
        Title = title;
    }

      public string GetDescription(){
        return description;
    }
    public void SetDescription(string script){
        description =script;
    }

    public string GetDate(){
        return date;
    }
    public void SetDate(string Date){
        date =Date;
    }
 public string GetTime(){
        return Time;
    }
    public void SetTime(string clock){
        Time =clock;
    }

    public string StandardDetails(){
       return $"{Title} \n Summary:{description} \nDate: {date} \nevent start: {Time}";
    }
    public string ShortDetails(){
        return $"{eventType}, {Title}, {date}";
    }
}