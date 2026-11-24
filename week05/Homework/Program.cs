using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetName("Mary Waters");
        assignment1.SetTopic("European History");

        MathAssignment mathAssignment1 = new MathAssignment();
        mathAssignment1.SettextbookSection("7.3");
        mathAssignment1.SetProblems("18-19");

        WritingAssignment writingAssignment1 = new WritingAssignment();
        writingAssignment1.SetTitle("The Causes of World War II by Mary Waters");


        Console.WriteLine(assignment1.GetSummaryInfo());
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}