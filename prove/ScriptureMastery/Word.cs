public class Word
{
    private string _word;
    private bool _isHidden;
    private string _hiddenWord;

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public void Display()
    {
        if(_isHidden == false)
        {
            Console.WriteLine(_word);
        }
        else{
            Console.WriteLine("");
        }
    }
}