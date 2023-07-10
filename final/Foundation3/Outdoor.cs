public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string name, string desc, string date, string time, Address address) : base(name, desc, date, time, address)
    {
        _weather = weather;
    }

    public override void FullMessage()
    {
        Console.WriteLine("Type: Lecture");
        base.FullMessage();
        Console.WriteLine($"Email: {_weather}");
    }
}