public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity) : base(name, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}