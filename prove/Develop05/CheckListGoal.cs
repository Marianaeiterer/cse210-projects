public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if(_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        
        return _points;
        
    }

    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            return true;
        }

        return false;
    }

    public override string GetDetailsString() 
    {
        if(IsComplete()){
            return $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }else{
            return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}/-/{_description}/-/{_points}/-/{_bonus}/-/{_target}/-/{_amountCompleted}";
    }
}