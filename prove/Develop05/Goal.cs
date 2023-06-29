public abstract class Goal
{
    protected string _name;
    protected double _points;
    protected string _description;
    protected bool _iscomplete = false;

    public Goal(double points, string description)
    {
        _points = points;
        _description = description;
    }

    public double GetPoints(){

    }

    public void Display(){

    }
}