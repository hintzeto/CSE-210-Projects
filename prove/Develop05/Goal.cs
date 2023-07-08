public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;
    protected bool _isComplete;

    public Goal(int points, string name, string description, bool isComplete = false)
    {
        _points = points;
        _description = description;
        _name = name;
        _isComplete = isComplete;
    }

    public virtual int Record(){
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have finished {_name}. You earned {_points} points.");
        return _points;
    }

    public virtual void Display(){
        
        Console.WriteLine($"Name: {_name}       Status: {_isComplete}");
    }

    public virtual bool CheckStatus(){
        return _isComplete;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual string GetSaveData(){
        return _name + "\n" + _points + "\n" + _description + "\n" + _isComplete;
    }

}