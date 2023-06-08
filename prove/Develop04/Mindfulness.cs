public class Mindfulness
{
   protected string _startingMessage;
   protected string _endingMessage;
   protected int _duration;

   public Mindfulness(string name, string description)
   {
    Console.WriteLine("How long would you like to do this activity in minutes?");
    string duration = Console.ReadLine();
        int _duration = int.Parse(duration);
    _startingMessage = $"Now starting {name}. {description}. This activity will take {_duration} minutes to complete.";
   }

   public void display()
   {
    Console.WriteLine($"{_startingMessage}");
   }

   public void wait()
   {
    
   }
}