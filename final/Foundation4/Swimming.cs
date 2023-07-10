public class Swimming : Activity
{
    private double _laps; 

    public Swimming(double laps, string date, double time) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override double GetDistance()
    {
        return ((_laps * 50) / 1000) * .62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

        public override string GetActivity()
    {
        return "Swimming";
    }
}