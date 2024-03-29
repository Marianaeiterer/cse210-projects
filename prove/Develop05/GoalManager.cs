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
        int answer = -1;

        while(answer !=6 )
        {
            
            DisplayPlayerInfo();

            Console.WriteLine($"Menu Options: ");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");

            Console.Write("Select a choice from the menu: ");
            answer =  int.Parse(Console.ReadLine());

            if(answer == 1)
            {
                CreateGoal();

            }
            else if(answer == 2)
            {
                ListGoalDetails();
            }
            else if(answer == 3)
            {
                SaveGoals();
            }
            else if(answer == 4)
            {
                LoadGoals();
            }
            else if(answer == 5)
            {
                RecordEvent();
            }

        }
        
    }

    public void DisplayPlayerInfo()
    {
        
        Console.WriteLine($"\nYou have {_score} points\n");
        
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for(var i = 0; i < _goals.Count; i ++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetShortName()}"); 
        }
    }

    public void ListGoalDetails()
    {
        
        for(var i = 0; i < _goals.Count; i ++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine(" 4. Bad Habit (You lose points if you do it)");
        Console.Write("Which type of goal would you like to create? ");
        int answer = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(answer == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if(answer == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if(answer == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            
            CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(checkListGoal);
        }
        else if(answer == 4)
        {
            Console.Write("How many times does this bad habit will happen before you lose bonus points? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus you will lose if you repeat this bad habit that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            
            BadHabit badHabit = new BadHabit(name, description, points, target, bonus);
            _goals.Add(badHabit);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int answer = int.Parse(Console.ReadLine());
        answer--;
        
        for(var i = 0; i < _goals.Count; i ++)
        {
            if(answer == i && _goals[i].GetType() != typeof(BadHabit))
            {
                int points = _goals[i].RecordEvent();
                _score += points;

                Console.WriteLine($"Congratulations! You have earned {points} points!");
            }
            else if(answer == i && _goals[i].GetType() == typeof(BadHabit))
            {
                int points = _goals[i].RecordEvent();
                _score -= points;

                Console.WriteLine($"I'm sorry! You have lost {points} points!");
            }
           
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            outputFile.WriteLine(_score);

            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal}:{goal.GetStringRepresentation()}");
            }
          
        }
    }

    public void LoadGoals()
    {
        
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        
        foreach (string line in lines)
        {
            
            string[] parts = line.Split(":");

            if(parts[0] == "SimpleGoal")
            {
                string[] partsSimple = parts[1].Split("/-/");

                string name = partsSimple[0];
                string description = partsSimple[1];
                int points = int.Parse(partsSimple[2]);
                bool complete = bool.Parse(partsSimple[3]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                if(complete)
                {
                    simpleGoal.RecordEvent();
                }

                _goals.Add(simpleGoal);
            }
            else if(parts[0] == "EternalGoal")
            {
                string[] partsSimple = parts[1].Split("/-/");

                string name = partsSimple[0];
                string description = partsSimple[1];
                int points = int.Parse(partsSimple[2]);

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if(parts[0] == "CheckListGoal")
            {
                string[] partsSimple = parts[1].Split("/-/");

                string name = partsSimple[0];
                string description = partsSimple[1];
                int points = int.Parse(partsSimple[2]);
                int bonus = int.Parse(partsSimple[3]);
                int target = int.Parse(partsSimple[4]);
                int amount = int.Parse(partsSimple[5]);

                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);

                for(var i = 0; i < amount; i++)
                {
                    checkListGoal.RecordEvent();
                }

                _goals.Add(checkListGoal);
            }
            else if(parts[0] == "BadHabit")
            {
                string[] partsSimple = parts[1].Split("/-/");

                string name = partsSimple[0];
                string description = partsSimple[1];
                int points = int.Parse(partsSimple[2]);
                int bonus = int.Parse(partsSimple[3]);
                int target = int.Parse(partsSimple[4]);
                int amount = int.Parse(partsSimple[5]);

                BadHabit badHabit = new BadHabit(name, description, points, target, bonus);

                for(var i = 0; i < amount; i++)
                {
                    badHabit.RecordEvent();
                }

                _goals.Add(badHabit);
            }
        }
    }

}