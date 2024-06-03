using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("10 May 2024", 30, 3);
        Swimming swimming = new Swimming("11 May 2024", 60, 100);
        Cycling cycling = new Cycling("12 May 2024", 90, 13);

        List<Activity> activities = new List<Activity>() {running, swimming, cycling};

        foreach(Activity activity in activities) 
        {
           string summary = activity.GetSummary();
           Console.WriteLine(summary);
        }
    }
}