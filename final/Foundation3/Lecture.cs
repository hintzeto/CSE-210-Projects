public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string name, string desc, string date, string time, Address address, string speaker, int capacity) : base(name, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullMessage()
    {
        Console.WriteLine("Type: Lecture");
        base.FullMessage();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }
}