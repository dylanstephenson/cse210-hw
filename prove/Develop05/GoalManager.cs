using System.Formats.Asn1;
using System.IO;

public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        // Declaring variable for user input at the start so that while loop doesn't break
        string userInput = "0";

        // Display main menu
        while (userInput != "7")
        {
            // Always start the menu with the points
            DisplayPlayerInfo();

            // Even though they are entering numbers, we'll leave the input as strings so that we don't have to parseInt for all the if statements.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Get Rank");
            Console.WriteLine("\t7. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            }
            else if (userInput == "2")
            {
                ListGoalDetails();
            }
            else if (userInput == "3")
            {
                SaveGoals();
            }
            else if (userInput == "4")
            {
                LoadGoals();
            }
            else if (userInput == "5")
            {
                RecordEvent();
            }
            else if (userInput == "6")
            {
                GetRank();
            }
            else if (userInput == "7")
            {
                break;
            }
            else{
                Console.WriteLine("That input is not recognized");
            }
        }
        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
     public void ListGoalNames()
    {
        // loop through goal list to display names for the record event function
        Console.WriteLine("The goals are:");
        int goalIndex = 0;
        foreach (Goal goal in _goals)
        {
            goalIndex++;
            string goalName = goal.GetName();
            Console.WriteLine($"{goalIndex}. {goalName}");
        }
        
    }
    
    public void ListGoalDetails()
    {
        // loop through goal list to display names and descriptions for the list goals menu item. 
        int goalIndex = 0;
                foreach (Goal goal in _goals)
                {
                    string goalName = goal.GetName();
                    string goalDetails = goal.GetDetailsString();
                    goalIndex++;
                    if (goal.IsComplete())
                    {
                        Console.WriteLine($"{goalIndex}. [X] {goalName} {goalDetails}");
                    }
                    else { 
                        Console.WriteLine($"{goalIndex}. [ ] {goalName} {goalDetails}");
                    }
                }
    }
    public void CreateGoal()
    {
        Console.Clear();
        // user input in main menu is used in the constructors to create goals using this function. This will display a new menu. Will add goal object to list when created.
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        // this will create a new variable goalType which we will use later to create the goal. 
        string typeInput = Console.ReadLine();
        string goalType;

        if (typeInput == "1")
        {
            goalType = "SimpleGoal";
        }
        else if (typeInput =="2")
        {
            goalType = "EternalGoal";
        }
        else if (typeInput == "3")
        {
            goalType = "ChecklistGoal";
        }
        else {
            goalType = "";
        }

        // Adding the name attribute to the goal for the constructor
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        // Adding the description attribute to our constructor
        Console.Write("What is a description for it? ");
        string goalDescription = Console.ReadLine();

        // Adding point value for completing the goal 
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalType == "ChecklistGoal")
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int goalCompleted = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, goalPoints, goalCompleted, goalBonus);
            _goals.Add(checklist);
        }
        else if(goalType == "SimpleGoal")
        {
            SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simple);
        }
        else if(goalType == "EternalGoal")
        {
            EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternal);
        }


    }
    public void RecordEvent()
    {
        // add returned points from goals to score total
        // User will need to select goals from a menu
        // Correct RecordEvent will need to be run depending on which goal is selected. Will need to check the list for goal type and run that type's RecordEvent.
        // Depending on parameters met, the event will update the goal to show if it's been completed or not
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        int goalPoints = _goals[goalIndex].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
        
        _score += goalPoints;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()
    {
        string goalFile;
        Console.Write("What is the file name for goal file? ");
        goalFile = Console.ReadLine();

        using (StreamWriter newFile = new StreamWriter(goalFile))
        {
        // save goals and points to a file. performs this by looping through goals and converting them to strings, saving them in a txt file.

            newFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                string goalString = goal.GetStringRepresentation();
                newFile.WriteLine(goalString);
            }
        }
    }
    public void LoadGoals()
    {
        // load goals and points from a text file
        string goalFile;
        Console.Write("What is the name of the goal file? ");
        goalFile = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(goalFile);

        int score = int.Parse(lines[0]);
        _score += score;

        // This loop iterates through each of the files, grabbing parameters for creating new objects based on the text in the file.
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");
            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int goalPoints = int.Parse(parts[3]);

            // the if statements handle the parameters that are unique to the goal, create the object, and add it to _goals.
            if (goalType == "SimpleGoal")
            {
                bool goalBool = bool.Parse(parts[4]);
                SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoints, goalBool);
                _goals.Add(simple);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eternal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completeAmount = int.Parse(parts[6]);
                ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus, completeAmount);
                _goals.Add(checklist);
            }
        }
    }
    public void GetRank()
    {
        if (_score < 500)
        {
            Console.WriteLine("\nSorry, you're still a noob and haven't ranked up yet.");
            Console.WriteLine("No worries, keep accomplishing your goals and you'll rank up in no time!");
        }
        else if (_score >= 500 && _score < 2000)
        {
            Console.WriteLine("\nYou are currently ranked as: Goal Knight");
            Console.WriteLine("Keep working at your goals, and one day, you could become a Goal King!");
        }
        else if (_score >= 2000 && _score < 5000)
        {
            Console.WriteLine("\nNice! You are currently ranked as: Goal King");
            Console.WriteLine("You have accomplished much, but there is still more to do! Do you have what it takes to become a Goal Emperor?");
        }
        else if (_score >=5000 && _score < 10000)
        {
            Console.WriteLine("\nCongratulations! You are currently ranked as: Goal Emperor");
            Console.WriteLine("Is there anywhere to go from here?");
        }
        else if (_score >= 10000)
        {
            Console.WriteLine("\nYou have earned the highest rank: Master of Self");
            Console.WriteLine("You are a master of setting and accomplishing goals. You have ascended to the top. Perhaps, it is time to start a new file");
        }
    }
}