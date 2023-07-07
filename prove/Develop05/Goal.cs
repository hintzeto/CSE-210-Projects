public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;
    protected bool _isComplete = false;

    public Goal(int points, string name, string description)
    {
        _points = points;
        _description = description;
        _name = name;
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

}