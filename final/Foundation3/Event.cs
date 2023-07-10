public class Event
{
    protected string _title;
    protected string _description;
    protected Address _address;
    protected string _date;
    protected string _time;

    public Event(string name, string desc, string date, string time, Address address)
    {
        _title = name;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardMessage()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address}");
    }

    public void ShortMessage()
    {
        Console.WriteLine($"Title: {_title}\nDate:{_date}");
    }

    public virtual void FullMessage()
    {
        StandardMessage();
    }
}