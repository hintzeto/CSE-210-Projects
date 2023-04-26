public class Book
{

    private string _author;
    private string _name;
    private int _timesRead = 0;
    private bool _available = true;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
        if(!_available)
        {
            Console.WriteLine("[Checked Out]");
        }
        else
        {
            Console.WriteLine("[Available]");
        }
    }

    public void CheckOut()
    {
        _available = false;
    }

    public bool IsAvailable()
    {
        return _available;
    }

    public void CheckIn()

    {
        _available = true;
        _timesRead += 1;
    }

    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
}