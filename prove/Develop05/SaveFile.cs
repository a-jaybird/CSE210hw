using System.IO;
using System.Security;
public class SaveFile{


public void SaveTheFile(List<Goals>entries, int score){
    
    Console.WriteLine("What do you want to call this file?");
    string filename =  Console.ReadLine();
    List<string> parts= new List<string>();
    foreach(Goals part in entries){
        parts.Add(part.ToString());
            
    }
    parts.Add("Score: "+ score );
    // foreach(string part in parts){
    //     Console.WriteLine(part);
    
    System.IO.File.WriteAllLines(filename, parts);


}

    internal void SaveTheFile(object entries)
    {
        throw new NotImplementedException();
    }
}