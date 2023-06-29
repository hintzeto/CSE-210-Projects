public class Mindfulness
{
   protected string _startingMessage;
   protected string _endingMessage;
   protected int _duration;

   public Mindfulness(string name, string description)
   {
    Console.WriteLine("How long would you like to do this activity in seconds?");
    string duration = Console.ReadLine();
    _duration = int.Parse(duration);
    _startingMessage = $"Now starting {name}. {description} \nThis activity will take {_duration} seconds to complete.";
    _endingMessage = $"Thank you for participating in {name}. This activity took you {_duration} seconds to complete";
   }

   public virtual void Display()
   {
    Console.WriteLine($"{_startingMessage}");
   }

   public virtual void End()
   {
      Console.WriteLine("You finished! Good work.");
      Thread.Sleep(2000);
      Console.WriteLine($"{_endingMessage}");
   }

   public virtual void Animation()
   {
            Console.Write(":");
            Thread.Sleep(1000);
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write(")");
            Thread.Sleep(1000);
   }
}