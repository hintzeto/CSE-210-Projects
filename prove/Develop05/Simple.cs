public class Simple : Goal
{
    private bool _isComplete = false;

    public Simple(double points, string description) : base(points, description)
    {
        
    }

    public void Record(){
        _isComplete = true;
    }

    public bool CheckComplete(){
        string answer = "";
        if(_isComplete == true){
            answer = "Complete";
        }
        else{
            answer = "Incomplete";
        }
        Console.WriteLine($"This goal is {answer}");
        return _isComplete;
    }
}