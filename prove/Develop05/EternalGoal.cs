public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }   
    public override void RecordEvent()
    {

    }
    public override bool isComplete()
    {   
        return false;
    }
    public override string GetDetails()
    {
        return $"{_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal, {_shortName}, {_description}, {_points}";
    }
}