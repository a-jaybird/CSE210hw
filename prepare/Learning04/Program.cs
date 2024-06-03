using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Steve Rogers");
        assignment1.SetTopic("Language!");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();

        assignment2.SetStudentName("Harold");
        assignment2.SetTopic("Math");
        assignment2.SetTextbookSection("section 7.3");
        assignment2.SetProblems("problems 10-20");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Esme Weatherwax");
        assignment3.SetTopic("Headology");
        assignment3.SetTitle("Art of Borrowing");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}