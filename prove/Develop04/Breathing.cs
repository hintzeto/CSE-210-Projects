public class Breathing : Mindfulness
{
    
    public Breathing(string name, string description) : base(name, description)
    {

    }

    public void Breathe()
    {
        for(int i = _duration; i > 0; i--){
        Console.WriteLine("Breathe in...");
        Animation();
        Console.WriteLine("Breathe out...");
        Animation();
        Console.WriteLine();
        }
    }

}