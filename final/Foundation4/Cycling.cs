public class Cycling : Activity
{
    private double _distance;

    public Cycling(double distance, string date, double time) : base(date, time)
    {
        _distance = distance;
    }

public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

            public override string GetActivity()
    {
        return "Cycling";
    }

}