public class Listing : Mindfulness
{
    List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    List<string> _responses = new List<string> {};

    public Listing(string name, string description) : base(name, description)
    {

    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];
        Console.WriteLine($"This is your prompt.\n{selectedPrompt}");

        return selectedPrompt;
    }

    public void Timer()
    {
        Console.WriteLine("Please take 5 seconds to think about the propmt.");
        for(int i = 5; i > 0; i--){
        Console.WriteLine(i);
        Thread.Sleep(1000);
        }
    }

    public void GetResponse()
    {
        Console.WriteLine("Please write your responses: ");
        for(int i = _duration; i > 0; i--){
        string response = Console.ReadLine();
        _responses.Add(response);
        }
    }

    
}