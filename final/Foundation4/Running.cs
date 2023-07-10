public class Running : Activity
{
    private double _distance; 

    public Running(double distance, string date, double time) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override string GetActivity()
    {
        return "Running";
    }
}