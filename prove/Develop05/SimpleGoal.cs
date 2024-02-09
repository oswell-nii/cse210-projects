public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool isComplete()
    {
        return _isComplete;
    }
    

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {_shortName}, {_description}, {_points}, {_isComplete}";
    }
    
    public override string GetDetails()
    {
        return $"{_shortName} ({_description})";
    }

}