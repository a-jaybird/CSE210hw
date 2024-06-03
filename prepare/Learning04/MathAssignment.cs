public class MathAssignment : Assignment{
    private string _textBookSection = "";
    private string _problems = "";

    public string GetTextbookSection(){
        return _textBookSection;
    }
    public void SetTextbookSection(string textbooksection){
        _textBookSection = textbooksection;
    }
    public string GetProblems(){
        return _problems;
    }
    public void SetProblems(string problems){
        _problems = problems;
    }

    public string GetHomeworkList(){

        return $"{_textBookSection} {_problems}";
    }



}