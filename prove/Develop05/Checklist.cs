public class Checklist : Eternal
{
    int _current;
    int _target;
    double _bonusPoints;

    public Checklist(double points, string name, string description, int target, double bonus, int current = 0) : base(points, name, description)
    {
        _target = target;
        _bonusPoints = bonus;
        _current = current;
    }

    public override void Display()
    {
        if(_current < _target){Console.WriteLine($"You have completed {_name} {_current}/{_target} times. You earned {_points} points.");}
        else{Console.WriteLine($"Congratulations you have finished your goal {_current}/{_target} times! You have received {_bonusPoints} extra points.");}
    }

    public override double Record()
    {
        _current += 1;
        if(_current == _target){return base.Record() + _bonusPoints;}
        else{return base.Record();}
    }

    public override int GetCount(){
        return _current;
    }

}