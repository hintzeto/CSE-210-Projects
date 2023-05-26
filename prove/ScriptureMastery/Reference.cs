public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference()
    {

    }

    public Reference(int firstVerse)
    {
        _firstVerse = firstVerse;
        _lastVerse = firstVerse;
    }

    public Reference(int firstVerse, int lastVerse)
    {
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }


    public void Display()
    {
        if(_firstVerse != _lastVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
        else{
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
    }
}