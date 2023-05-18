public class Prompt
{
    List<string> _prompts = new List<string> { "What are the top three things that you are grateful for in your life right now, and why?",
    "Think about a recent experience that challenged you in some way. What did you learn from it, and how has it impacted you moving forward?",
    "What is something that you have been putting off or avoiding? What is holding you back, and what can you do to overcome this obstacle?",
    "Describe a time when you had to make a difficult decision. How did you weigh the pros and cons, and ultimately make your choice?",
    "Reflect on a personal accomplishment that you are proud of. What did it take to achieve this goal, and how did you feel when you succeeded?",
    "What is something that you have been curious about lately? What steps can you take to learn more about this topic or area of interest?",
    "Write about a person who has had a significant impact on your life. How did they influence you, and what lessons did you learn from them?",
    "Imagine that you could go back in time and give advice to your younger self. What would you say, and why?",
    "What is something that you would like to improve about yourself? What steps can you take to work on this area of personal growth?",
    "Reflect on a recent moment of joy or happiness in your life. What made this experience so special, and how can you cultivate more of these moments in the future?" };

    public Prompt()
    {
        
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];

        return selectedPrompt;
    }

}