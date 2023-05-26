public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _ref;

    public Scripture(string scripture, Reference reference)
    {
        _ref = reference;
        _words = ConvertStringToList(scripture);
    }

    public void Display()
    {

    }

    public string ConvertStringToList()
    {
        List<string> stringList = scripture.Split(delimiter).ToList();

        return stringList;
    }

    public void HideWords()
    {

    }

    public void TotallyHidden()
    {

    }

    public void ShowAll()
    {

    }
}