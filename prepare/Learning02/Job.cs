public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"Title: {_jobTitle} Company: {_company} Start: {_startYear} End: {_endYear}");
    }
}