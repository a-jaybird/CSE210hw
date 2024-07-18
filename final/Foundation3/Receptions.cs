public class Receptions: Events{

    private string contactEmail;
    public Receptions(){
        eventType ="Reception";
    }

      public string GetContact(){
        return contactEmail;
    }
    public void SetContact(string RSVP){
        contactEmail =RSVP;
    }

     public string ReceptionFull(){
        return $"{Title}  \nSummary:{description} \nDate: {date} \nevent start: {Time} \nplease RSVP at: {contactEmail}";
    }



}