using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Word{
    
    string text;
    bool isHidden;
    public Word(string blah){
        text = blah;

        isHidden = false;

    }
    public bool getIsHidden(){
        return isHidden;
    }
    public void setIsHidden(bool hidden){
        isHidden =hidden;
    }
   public string getWord(){
    

        if (isHidden){
            string t = "";
            for(int i = 0; i < text.Length; ++i)
            // iterates through each letter of a word
            {
                t += "_";
                
            }
            return t;

        }
        return text;

    }

}