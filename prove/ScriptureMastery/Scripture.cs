public class Scripture
{
    private List<string> _words = new List<string>();
    private Reference _ref;
    private string _scripture;

    public Scripture(string scripture, Reference reference)
    {
        _scripture = scripture;
        _ref = reference;
        _words = ConvertStringToList();
    }

    public void Display()
    {

    }

    public List<string> ConvertStringToList()
    {
        char delimiter = ' ';
        List<string> stringList = _scripture.Split(delimiter).ToList();

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