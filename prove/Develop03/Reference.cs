using Microsoft.Win32.SafeHandles;

public class Reference{
    private string rude;
    public Reference(string r){

        //  List<string> references;
        // references = new List<string>();
        // references.Add("Ether 12:27-28");
        rude = r;
    }

    public string getRef(){
        return rude;
    }

}