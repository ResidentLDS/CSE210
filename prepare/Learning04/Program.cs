using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Steven Klybeck", "Algebra");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3 Problems 8-19");
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        WritingAssignment myWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II by Mary Waters");
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }

}