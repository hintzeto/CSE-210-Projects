public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _response;
    public Prompt _prompt = new Prompt();
    public string randomPrompt;

    public Entry()
    {
        randomPrompt = _prompt.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        _response = Console.ReadLine() ?? string.Empty;
        _date = DateTime.Now;
    }

    // public string getResponse()
    // {
    //     Console.Write("Please enter your response: ");
    //         string response = Console.ReadLine();
    //     return response;
    // }

    // public void recievePrompt()
    // {
    //     Prompt p = new Prompt();
    // }


    public string stringTheory()
    {
        return($"{_date}/n{_prompt}/n{_response}");
    }


}