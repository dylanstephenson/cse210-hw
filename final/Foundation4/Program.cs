using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new("10 May 2024", 30, 3);
        Swimming swimming = new("11 May 2024", 60, 100);
        Cycling cycling = new("12 May 2024", 90, 13);

        List<Activity> activities = [running, swimming, cycling];

        foreach(Activity activity in activities) 
        {
           string summary = activity.GetSummary();
           Console.WriteLine(summary);
        }
    }
}