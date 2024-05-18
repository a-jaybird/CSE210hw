using System;

// Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the journal and display them to the screen.
// Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
// Provide a menu that allows the user choose these options
// Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
// 
// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?

class Program
{
    static void Main(string[] args)

    {

        // string journal ="entries.txt";
        // string readEntries = File.ReadAllText(journal);
        

     
        List<string> entries;
        entries = new List<string>();
    while(true){
        Console.WriteLine("Welcome to the journal, pleas choose:");
        Console.WriteLine("1 to start a new entry");
        Console.WriteLine("2 to view ones currently stored");
        Console.WriteLine("3 to load a previous file");
        Console.WriteLine("4 move stored entries onto a seperate file");
        Console.WriteLine("5 to quit");

        string user= Console.ReadLine();
        int input = int.Parse(user);

        if(input == 1){
            
            PromptGenerator p =new PromptGenerator();
            string tellMe= p.Prompt();
            Console.WriteLine(tellMe);

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            string entry = Console.ReadLine();
            
            entries.Add(dateText + " "+ tellMe + '\n' + entry);
            // \n breakline            



        }
        else if(input == 2){
            entries.ForEach(entry => Console.WriteLine(entry));



        }
        else if(input ==3){
            // GET OVER HERE
            // public static System.IO.StreamReader OpenText (string path);
            Console.WriteLine("What file do you want: ");
            string upload =Console.ReadLine();
            
            // string readText = File.ReadAllText(upload);

            using (StreamReader sr = File.OpenText(upload))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
                string s1 = sr.ReadLine();
                entries.Add(s+"\n"+ s1 );

            }
            }
    
        }

        else if (input == 4 ){
            // yeet that code
            yeetTheFile ytf= new yeetTheFile();
            ytf.saveTheFile(entries);


        }

        else{

            Console.Write("Goodbye.");
            return;
         }
        // static int DateTime(){

        // }
        // static string WriteEntry()
        
        {}
    }
        

}



}