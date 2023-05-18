public class Fraction
{
    private int _top = 1;
    private int _bottom = 1;


    public Fraction()
    {

    }
    
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string str = $"{_top}/{_bottom}";
        return str;
    }

    public double GetDecimalValue()
    {
        double value = _top / _bottom;
        return value;
    }

    public void Display()
    {
        Console.WriteLine($"");
    }
}