public class User
{
    private string _userName;
    private int _score;
    private List<Simple> _simpleGoals = new List<Simple>();
    private List<Checklist> _checklistGoals = new List<Checklist>();
    private List<Eternal> _eternalGoals = new List<Eternal>();

    public User(string name)
    {
        _userName = name;
    }

    public User(string name, List<Simple> simple, List<Checklist> checklist, List<Eternal> eternal)
    {
        _userName = name;
        _simpleGoals = simple;
        _checklistGoals = checklist;
        _eternalGoals = eternal;
        _score = 0;
        foreach(Simple goal in _simpleGoals)
        {
            if(goal.CheckStatus())
            {
                _score += goal.GetPoints();
            }
        }

        foreach(Checklist goal in _checklistGoals)
        {
            if(goal.CheckStatus())
            {
                _score += goal.GetPoints();
            }
        }

        foreach(Eternal goal in _eternalGoals)
        {
                _score += goal.GetPoints();
        }
    }



// Function for adding simple goal
    public void AddGoal(Simple goal)
    {
        _simpleGoals.Add(goal);
    }
// Function for adding checklist goal
    public void AddGoal(Checklist goal)
    {
        _checklistGoals.Add(goal);
    }
// Function for adding eternal goal
    public void AddGoal(Eternal goal)
    {
        _eternalGoals.Add(goal);
    }

    public void ViewSimpleGoals(bool showComplete = true, bool showIndex = false)
    {
        int counter = 0;
        foreach(Simple goal in _simpleGoals){
            if(showComplete == true || goal.CheckStatus() == false)
            {
                if(showIndex == true)
                {
                    Console.Write($"ID: {counter} ");
                }
            goal.Display();
            counter += 1;}
    }
    }

    public void ViewChecklistGoals(bool showComplete = true, bool showIndex = false)
    {
        int counter = 0;
        foreach(Checklist goal in _checklistGoals){
            if(showComplete == true || goal.CheckStatus() == false)
            {
                if(showIndex == true)
                {
                    Console.Write($"ID: {counter} ");
                }
            goal.Display();
            counter += 1;}
    }
    }

    public void ViewEternalGoals(bool showIndex = false)
    {
        int counter = 0;
        foreach(Eternal goal in _eternalGoals){
            if(showIndex == true){
                Console.Write($"ID: {counter} ");
            }
            goal.Display();
            counter += 1;
        }
    }

    public void ViewAllGoals(bool showComplete = true)
    {
        ViewSimpleGoals(showComplete);
        ViewChecklistGoals(showComplete);
        ViewEternalGoals();
    }

    public int RecordSimpleGoal(int index)
    {
        return _simpleGoals[index + _simpleGoals.Count - 1].Record();
    }

    public int RecordChecklistGoal(int index)
    {
        return _checklistGoals[index].Record();
    }

    public int RecordEternalGoal(int index)
    {
        return _eternalGoals[index].Record();
    }

    public void AddScore(int points)
    {
        _score += points;
    }

    public int GetScore()
    {
        return _score;
    }

    public string GetName()
    {
        return _userName;
    }

    public string GetSaveData(){
        string save = _simpleGoals.Count + "\n" + _checklistGoals.Count + "\n" + _eternalGoals.Count;

        foreach(Simple goal in _simpleGoals)
        {
            save += "\n" + goal.GetSaveData();
        }
        foreach(Checklist goal in _checklistGoals)
        {
            save += "\n" + goal.GetSaveData();
        }
        foreach(Eternal goal in _eternalGoals)
        {
            save += "\n" + goal.GetSaveData();
        }
        
        return save;
    }


}