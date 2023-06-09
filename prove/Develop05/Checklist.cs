public class Checklist : Eternal
{

    int _target;
    int _bonusPoints;

    public Checklist(int points, string name, string description, int target, int bonus, int current = 0, bool isComplete = false) : base(points, name, description, current, isComplete)
    {
        _target = target;
        _bonusPoints = bonus;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {_name}     Progress: {_current}/{_target}");
    }

    public override int Record()
    {
        _current += 1;
        if(_current < _target)
            {
            _isComplete = false;
            }
        else{
            _isComplete = true;
        }

        if(_current == _target)
        {
            Console.WriteLine($"Congratulations! You have finished {_name}. You earned {_points} points. You have now fully completed this goal! You have earned {_bonusPoints} extra points");
            return _points + _bonusPoints;
            }

        else{
            Console.WriteLine($"Congratulations! You have finished {_name}. You earned {_points} points. This goal has been completed {_current}/{_target} times.");
            return _points;
            }
    }

    public override int GetCount(){
        return _current;
    }

    public override string GetSaveData()
    {
        return base.GetSaveData() + "\n" + _target + "\n" + _bonusPoints;
    }

    public override int GetPoints()
    {
        if(_isComplete == true)
        {
            return (_points * _target) + _bonusPoints;
        }
        else{
            return _points * _current;
        }
         
    }

}