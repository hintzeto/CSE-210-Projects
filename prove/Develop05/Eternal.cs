public class Eternal : Goal
{
    protected int _current;

    public Eternal(int points, string name, string description, int current = 0, bool isComplete = false) : base(points, name, description, isComplete)
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

    public override string GetSaveData()
    {
        return base.GetSaveData() + "\n" + _current;
    }

    public override int GetPoints()
    {
        return _points * _current;
    }

}