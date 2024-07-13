using System.Security.AccessControl;

public class Comments{

    // public string CommentAuthor;
    // public string CommentBody;
    List<string>commenters = new List<string>();
     List<string>commentBodies = new List<string>();
    public Comments(){
    commenters.Add("GrayM0use");
    commenters.Add("Ant1neph1s");    
    commenters.Add("123ABC");
    commenters.Add("Tr0lllololololol");
    commenters.Add("R0BNEB0D");
    commenters.Add("Pion33r47");
    commentBodies.Add("Need more cowbell");
    commentBodies.Add("Love this. 10/10 would rewatch");
    commentBodies.Add("my crops are watered. my skin is clear. perfection.");
    commentBodies.Add("Nae King nae Queen! We willna be fooled again!");
    commentBodies.Add("No thanks, I'll stick to the old fashioned ways.");
    commentBodies.Add("So insightful. We need more people like you.");
    commentBodies.Add("If you ask Rick Astley for a copy of the movie “UP”, he cannot give you it as he can never give you up. But, by doing that, he is letting you down, and thus, is creating something known as the Astley Paradox.");
    }
    public void Publish(){
        Random rnd = new Random();
        int r = rnd.Next(commenters.Count);
        Random random = new Random();
        int x = random.Next(commentBodies.Count);
        Console.WriteLine($"Username: {commenters[r]} \nComment: {commentBodies[x]}");
    }
}