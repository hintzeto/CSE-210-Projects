public class WritingAssignment : Assignment
{
    protected string _title = "";

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_studentName} - {_topic}\nTitle: {_title}";
    }
}