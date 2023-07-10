public class Activity
{
    protected string _date;
    protected double _time;

    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }

    public virtual double GetTime()
    {
        return _time;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetActivity()
    {
        return "";
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetActivity()} ({_time} min)- Distance {Math.Round(GetDistance(), 1)} miles, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile");
    }


}