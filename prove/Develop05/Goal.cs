public abstract class Goal
{
    protected string _name;
    protected double _points;
    protected string _description;
    protected bool _isComplete = false;

    public Goal(double points, string name, string description)
    {
        _points = points;
        _description = description;
        _name = name;
    }

    public virtual double Record(){
        _isComplete = true;
        return _points;
    }

    public virtual void Display(){
        
        Console.WriteLine($"This worked. Good job! Points: {_points} Status: {_isComplete}");
    }

}