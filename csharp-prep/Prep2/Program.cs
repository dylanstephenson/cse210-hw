using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get in your class? ");
        string percentageFromUser = Console.ReadLine();

        int coursePercentage = int.Parse(percentageFromUser);
        string letterGrade;
        string sign;
        string determiner;

        if (coursePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (coursePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (coursePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (coursePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (coursePercentage % 10 >= 7 && !(letterGrade == "A" || letterGrade == "F"))
        {
            sign = "+";
        }
        else if (coursePercentage % 10 < 3 && !(letterGrade == "F"))
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        if (letterGrade == "A" || letterGrade == "F")
        {
            determiner = "an";
        }
        else
        {
            determiner = "a";
        }

        Console.WriteLine($"You got {determiner} {letterGrade}{sign} in the class.");

        if (letterGrade == "D" || letterGrade == "F")
        {
            Console.WriteLine("I'm sorry, you failed the class.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
    }
}