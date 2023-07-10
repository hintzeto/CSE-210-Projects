public class Reception : Event
{
    private string _rsvp;

    public Reception(string email, string name, string desc, string date, string time, Address address) : base(name, desc, date, time, address)
    {
        _rsvp = email;
    }

        public override void FullMessage()
    {
        Console.WriteLine("Type: Lecture");
        base.FullMessage();
        Console.WriteLine($"Email: {_rsvp}");
    }
}