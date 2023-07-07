public class Eternal : Goal
{
    int _current;

    public Eternal(int points, string name, string description, int current = 0) : base(points, name, description)
    {
        _current = current;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {_name}       Times completed: {_current}");
    }

    public override int Record()
    {
        _current += 1;
        Console.WriteLine($"Congratulations! You have finished {_name}. You earned {_points} points. You have completed this goal {_current} times.");
        return _points;
    }

    public virtual int GetCount(){
        return _current;
    }

}