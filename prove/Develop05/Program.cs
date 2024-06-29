using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    { 
        int points = 0;
        List<Goals> SelfGoals= new List<Goals>(); 
        while (true)
        {
        
         Console.WriteLine("Welcome to Goal Setter! please select an option below: \n"+
         "1. Create a new goal\n" + "2. list Goals \n"+ "3. Save Goals \n" + "4. Load Goals \n"
         +"5. Record Event\n" + "6. Quit"); 
         Console.WriteLine($"You have {points} points ");

         string userInput= Console.ReadLine();


            if (userInput== "1"){
                Console.WriteLine("What kind of goal do you want to make?"+ 
                " Press 1 for Simple goal, 2 for a Checklist goal, or 3 for an Eternal goal.");
                string options = Console.ReadLine();
                Goals g;

                    if(options == "1"){
                        g = new SimpleGoal();
                    }
                    else if(options== "2"){
                        
                        Console.WriteLine("how many times to do you want to complete this goal?");
                        string s = Console.ReadLine();
                        g = new ChecklistGoal();
                        Console. WriteLine("What kind of bonus points for completing?");
                        int bonus =int.Parse(Console.ReadLine());  
                        g.SetBonus(bonus);  
                        int XtoComplete = int.Parse(s);
                        g.SettimesToComplete(XtoComplete);
                        // to do: make a method that keep track how many times completed in Checklist
                    } 
                    else if(options == "3"){
                        g = new EternalGoal();
                    }
                    else{
                        Console.WriteLine("oops, try again.");
                        continue;
                    }
                    Console.WriteLine("What kind of goal are you hoping to set? ");
                    string goalInput = Console.ReadLine();
                    Console.WriteLine("how many points is this goal worth?");
                    string pointInput = Console.ReadLine();
                      int goalPoints = int.Parse(pointInput);
                     g.SetGoal(goalInput);
                     g.SetPoints(goalPoints);
                    SelfGoals.Add(g);
            }
            else if(userInput == "2"){
                // lists goals
                foreach(Goals selfgoal in SelfGoals){
                    Console.Write(selfgoal.GetCheckedOff() ? "[X]" : "[ ]");// if true, will x, if false will leave blank
                    Console.WriteLine(selfgoal);
                }

            }
            else if(userInput=="3"){
                //saves goals to file
                SaveFile s = new SaveFile();
                s.SaveTheFile(SelfGoals, points);
            }
            else if(userInput == "4"){
                //loads txt goal file
                SelfGoals = new List<Goals>();
                LoadFile file = new LoadFile();
                Console.WriteLine("What file do you want: ");
                string upload =Console.ReadLine();
            
            // string readText = File.ReadAllText(upload);

                using (StreamReader gl = File.OpenText(upload))
                 {
                    string s = "";
                    while ((s = gl.ReadLine()) != null)
                 {
                    //Console.WriteLine(s);
                    string[] newgoals= s.Split(new char[] {',', ':'});
                    if(newgoals[0] == "SimpleGoal"){
                        Goals b = new SimpleGoal();
                        b.SetGoal(newgoals[1]);
                        b.SetPoints(int.Parse(newgoals[2]));
                        b.SetCheckedoff(Boolean.Parse(newgoals[3]));
                        SelfGoals.Add(b);
                    } 
                    else if(newgoals[0] == "ChecklistGoal"){
                        Goals b = new ChecklistGoal();
                        b.SetGoal(newgoals[1]);
                        b.SetPoints(int.Parse(newgoals[2]));
                        b.SetBonus(int.Parse(newgoals[3]));
                        b.SetCheckedoff(Boolean.Parse(newgoals[4]));
                        b.SettimesToComplete(int.Parse(newgoals[5]));
                        SelfGoals.Add(b);
                    }
                    else if(newgoals[0] == "EternalGoal"){
                        Goals b = new EternalGoal();
                        b.SetGoal(newgoals[1]);
                        b.SetPoints(int.Parse(newgoals[2]));
                        b.SetCheckedoff(false);
                        SelfGoals.Add(b);
                    
                    }
                    else if (newgoals[0] == "Score") {
                        points =int.Parse(newgoals[1]);
                    }
                 }
                    
                    // Goals s1 = gl(s);
                    // SelfGoals.Add(s+"\n"+ s1 );

            }
            }
            else if(userInput == "5"){
                // asks if you completed a goal, checks it off, and adds points
                Console.WriteLine("The goals are as listed:");
                for(int i = 0; i < SelfGoals.Count();i++){
                    Console.WriteLine($"{i+1}. {SelfGoals[i].GetGoal()}");
                }
                Console.WriteLine("Indicate by number which you completed:");
                int iDidit= int.Parse(Console.ReadLine())-1;
                if( iDidit < SelfGoals.Count() && iDidit >= 0){
                    points += SelfGoals[iDidit].CheckOff();



                }    
            }
            
            else if(userInput == "6"){
               break; 
            }   
        }

    }
}
