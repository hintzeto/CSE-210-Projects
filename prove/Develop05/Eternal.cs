public class Eternal : Goal
{
    int _current;

    public Eternal(double points, string name, string description, int current = 0) : base(points, name, description)
    {
        _current = current;
    }

    public override void Display()
    {
        Console.WriteLine($"This is confirmation that you made progress on an eternal goal you goober. Points: {_points}");
    }

    public override double Record()
    {
        _current += 1;
        return _points;
    }

    public virtual int GetCount(){
        return _current;
    }

}