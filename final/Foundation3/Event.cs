public class Event
{
    private string _title;
    private string _description;
    private Address _address;
    private string _date;
    private string _time;

    public Event(string name, string desc, string date, string time, Address address)
    {
        _title = name;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardMessage()
    {
        // title, description, date, time, address
    }

    public string FullMessage()
    {
        //Add even specific info
    } 

    public string ShortMessage()
    {
        //Only type, title, date
    }
}