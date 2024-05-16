using System;
using System.Runtime.InteropServices;
// Showed CREATIVITY by adding a log that counts and displays how many activities have been done at the end of the program. Created another "counter" that shows emoji faces going from sad to happy. This counter is used in the DisplayEndingMessage() function.
class Program
{
    static void Main(string[] args)
    {
        // Creating my lists that will be used by Listing activity and Reflecting Activity
        List<string> listingPrompts = new List<string>()
        {
            "What are things that you feel grateful for this week?",
            "What have you been able to accomplish this month?",
            "How have you made time to take care of yourself this week?",
            "Who are people that inspire you to be better?",
            "How have you felt the spirit this month?"
        };

        List<string> reflectionPrompts = new List<string>()
        {
            "Think of a time when you overcame a weakness.",
            "Think of a time when you did something spontaneous.",
            "Think of a time when you sacrificed something you wanted for someone else's benefit.",
            "Think of a time when you felt genuinely happy.",
            "Think of a time when you received an answer to your prayers."
        };
        
        List<string> reflectionQuestions = new List<string>()
        {
            "What made this experience meaningful to you?",
            "Who was involved in that experience and how do you feel about them?",
            "How did this experience affect you going forward?",
            "Where did this happen and how do you feel about that place?",
            "Who would benefit if you shared this experience with them?",
            "What made this specific memory stand out over other experiences you've had?",
            "Have you ever tried to repeat this experience? If so, how did it go?",
            "What was the highlight of this experience?",
            "What lead to this experience happening?"
        };

        // Creating my breathing activity object that will be used in the program.
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity","This activity is designed to help you slow down, focus on your breathing, and let go of any pent up stress and other negative emotions.");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity invites you to ponder and write to help you slow down and see all the good that has happened to you recently.", listingPrompts);
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity encourages you to ponder deeply on experiences from your past, remembering and expounding them in your mind to help you pause and reflect on the good things in life.", reflectionPrompts, reflectionQuestions);
        
        string userInp = "0";
        int activityCount = 0;
        
        while (userInp != "4") 
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            Console.Write("> ");
            userInp = Console.ReadLine();

            if (userInp == "1")
            {
                Console.Clear();
                breathingActivity.Run();
                activityCount++;
            }
            else if (userInp == "2")
            {
                Console.Clear();
                reflectingActivity.Run();
                activityCount++;
            }
            else if (userInp == "3")
            {
                Console.Clear();
                listingActivity.Run();
                activityCount++;
            }
            else if (userInp == "4")
            {
                Console.Write($"Thank you for using the wellness app. ");
            }
            else {
                Console.WriteLine("That is not a menu option");
            }
        }
        if (activityCount == 1)
        {
            Console.WriteLine($"You completed {activityCount} activity.");
        }
        else 
        {
            Console.WriteLine($"You completed {activityCount} activities.");
        }
        
    }
}