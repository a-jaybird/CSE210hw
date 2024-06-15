public class WritingAssignment: Assignment{

    //sample answer's solution: public WritingAssignment(string studentName,string topic,string title){

    // }
    // the code I made works though.
    private string _title;

    public string GetTitle(){
        return _title;
    }
    public void SetTitle(string title){
        _title = title;

    }

    public string GetWritingInformation(){
        return $"{_title}";
    }
}