public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }
    public string GetDetailsString()
    {
        return $"{_shortName}: ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetDetails()
    {
        return $"{_shortName} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}