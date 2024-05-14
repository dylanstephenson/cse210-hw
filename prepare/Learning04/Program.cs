using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment hw = new Assignment("Dylan", "Math");

        MathAssignment mathHw = new MathAssignment("Dylan Stephenson", "Math", "7B", "1-10");

        WritingAssignment writeHw = new WritingAssignment("Sophie Anne", "English", "Bridge Over Troubled Water");

        Console.WriteLine(writeHw.GetSummary());
        Console.WriteLine(writeHw.GetWritingInformation());
    }
}