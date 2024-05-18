public class yeetTheFile{

public void saveTheFile(List<string>entries){
Console.WriteLine("What do you want to call this file?");
string filename =  Console.ReadLine();

System.IO.File.WriteAllLines(filename, entries);


}



}