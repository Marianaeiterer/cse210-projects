public class BadHabit : Goal
{
    private int _amountRepeated;
    private int _target;
    private int _bonus;

    public BadHabit(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _amountRepeated = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountRepeated++;
        if(_amountRepeated == _target)
        {
            return _points + _bonus;
        }
        
        return _points;
        
    }

    public override bool IsComplete()
    {
        if(_amountRepeated == _target)
        {
            return true;
        }

        return false;
    }

    public override string GetDetailsString() 
    {
        if(IsComplete()){
            return $"[X] {_shortName} ({_description}) -- Currently Repeated: {_amountRepeated}/{_target}";
        }else{
            return $"[ ] {_shortName} ({_description}) -- Currently Repeated: {_amountRepeated}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}/-/{_description}/-/{_points}/-/{_bonus}/-/{_target}/-/{_amountRepeated}";
    }
}