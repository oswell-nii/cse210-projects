using System.IO;
public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public GoalManager(int score)
    {
        _score = score;
    }
    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            }
            else if (userInput == "2")
            {
                ListGoalNames();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Enter the name for the file you want to save: ");
                string fileName = Console.ReadLine();
                SaveGoals(fileName);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Enter the name of the file: ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }
            else if (userInput == "5")
            {
                RecordEvent();
            }
            else if (userInput == "6")
            {
                exit = true;
            }
            
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("List of Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                string completionStatus = goal.isComplete() ? "[X]" : "[ ]";
                if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    Console.WriteLine($"{i + 1}. {completionStatus}  {((ChecklistGoal)goal).GetDetailsString()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {completionStatus} {goal.GetDetails()}");
                }
            }
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string completionStatus = _goals[i].GetCompletionStatus();
            Console.WriteLine($"{i + 1}. {completionStatus} {_goals[i].GetStringRepresentation()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Which goal would you like to create? ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Console.WriteLine("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, false));
        }
        else if (userInput == "2")
        {
            Console.WriteLine("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (userInput == "3")
        {
            Console.WriteLine("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, 0, goalTimes, goalBonus));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Select an accomplished goal from the list:");
        ListGoalNames();
        Console.Write("Enter the number of the accomplished goal: ");
        if (int.TryParse(Console.ReadLine(), out int selectedGoalIndex) && selectedGoalIndex > 0 && selectedGoalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[selectedGoalIndex - 1];
            int pointsEarned = selectedGoal._points;
            _score += pointsEarned;
            selectedGoal.RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

   
    
    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file, false))
        {  
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());   
            }
            outputFile.WriteLine($"Score: {_score}");
            Console.WriteLine("Saved to File!");
        }
    }
    public void LoadGoals(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        bool scoreLoaded = false;

        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");
            if (parts.Length >= 4)
            {
                string goalType = parts[0].Trim();
                string goalName = parts[1].Trim();
                string goalDescription = parts[2].Trim();

                if (goalType == "SimpleGoal")
                {
                    int goalPoints = int.Parse(parts[3].Trim());
                    bool goalCompletionStatus = bool.Parse(parts[4].Trim());
                    _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, goalCompletionStatus));
                }
                else if (goalType == "EternalGoal")
                {
                    int goalPoints = int.Parse(parts[3].Trim());
                    _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int goalPoints = int.Parse(parts[3].Trim());
                    int amountCompleted = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int bonus = int.Parse(parts[6].Trim());
                    _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, amountCompleted, target, bonus));
                }
                else if (line.StartsWith("Score: "))
                {
                    _score = int.Parse(line.Substring(7).Trim());
                    scoreLoaded = true;
                }
                if (scoreLoaded)
                {
                    Console.WriteLine($"Loaded saved data successfully! You have {_score} points.");
                }
            }
        }
    }

}