using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment info = new Assignment();
        info.SetStudentName("akounalo");
        info.SetTopic("fonction");

        Console.WriteLine(info.GetSummary());

        MathAssignment math = new MathAssignment();
        math.SetStudentName("akounalo");
        math.SetTopic("math");
        math.SetTextbookSection("7.3");
        math.SetProblems("1-10");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment();
        writing.SetStudentName("akounalo");
        writing.SetTopic("writing");
        writing.SetTitle("My First Writing Assignment");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetTitleInformation());
    }
}