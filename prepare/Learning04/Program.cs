using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Talon Hintze", "Inheritance");
        string assignment = assignment1.GetSummary();
        Console.WriteLine(assignment);

        MathAssignment math1 = new MathAssignment("Talon Hintze", "Project 2 Task 1", "7.1", "10-21 odd");

        string math = math1.GetHomeworkList();
        Console.WriteLine(math);
        string mathderived = math1.GetSummary();
        Console.WriteLine(mathderived);

        WritingAssignment writing1 = new WritingAssignment("Talon Hintze", "Writing Topic", "This Is The Title");
        string writing = writing1.GetWritingInfo();
        Console.WriteLine(writing);
        string writingderived = writing1.GetSummary();
        Console.WriteLine(writingderived);
    }
}