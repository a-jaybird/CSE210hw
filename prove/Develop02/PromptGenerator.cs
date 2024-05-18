public class PromptGenerator{

List<string> prompts;
public PromptGenerator(){
prompts = new List<string>();
prompts.Add(" What was the strongest emotion I felt today?");
prompts.Add("If I had one thing I could do over today, what would it be?");
prompts.Add("See any animals today?");
prompts.Add("Who did I speak with today?");
prompts.Add("What did you eat for breakfast?");
}
public string Prompt(){

        Random rnd = new Random();
        int r = rnd.Next(prompts.Count);
        return prompts[r];

}
}