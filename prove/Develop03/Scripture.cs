using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture{

List<Word> verses;
Reference x;

public Scripture()
{
// //     List<string> verses;
// //     verses = new List<string>();
// //    verses.Add("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.(\n) Behold, I will show unto the Gentiles their weakness, and I will show unto them that faith, hope and charity bringeth unto me—the fountain of all righteousness.");
verses = new List<Word>();
    List<string> verse = new List<string>(("And if men come unto me I will show unto them their weakness. "+
    "I give unto men weakness that they may be humble; and my grace is sufficient for all men "+
    "that humble themselves before me; for if they humble themselves before me, and have faith "+
    "in me, then will I make weak things become strong unto them.\n Behold, I will show unto "+
    "the Gentiles their weakness, and I will show unto them that faith, hope and charity bringeth "+
    "unto me—the fountain of all righteousness.").Split(' '));
    foreach (string ver in verse) {
        verses.Add(new Word(ver));   
    }
    x = new Reference("Ether 12:27-28");

}
    public void printVerse(){
        Console.WriteLine(x.getRef());
        foreach(Word w in verses){
            Console.Write(w.getWord() +" ");
        }
        Console.Write("\n");
    }
    public void hideWord(){
        Random rnd = new Random();
        for(int i = 0; i < 3; ++i){
            
            int index = rnd.Next(verses.Count());
            if(verses[index].getIsHidden()){
                --i;
                continue;
                
            }
            else{
                verses[index].setIsHidden(true);
            }

        }

    }
}