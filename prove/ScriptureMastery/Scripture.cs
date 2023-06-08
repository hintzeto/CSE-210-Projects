public class Scripture
{
    private List<Word> _words = new List<Word>();
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
        foreach(Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine();
    }

    public List<Word> ConvertStringToList()
    {
        char delimiter = ' ';
        List<string> stringList = _scripture.Split(delimiter).ToList();

        List<Word> wordList = new List<Word>();
        foreach(string word in stringList)
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public void HideWords()
    {
        int count = _words.Count;
        double toRemove = Math.Ceiling(count * .1);
        Random random = new Random();

        while(toRemove > 0)
        {
            int randomIndex = random.Next(count);
            if(!_words[randomIndex].GetHidden()){
                _words[randomIndex].HideWord();
                toRemove--;
            }
            if(TotallyHidden()){
                break;
            }
        }
    }

    public bool TotallyHidden()
    {
        foreach(Word word in _words){
            bool hidden = word.GetHidden();
            if(!hidden){
                return false;
            }
        }
        return true;
    }

    public void ShowAll()
    {
        foreach(Word werd in _words)
        {
            werd.ShowWord();
        }
    }
}