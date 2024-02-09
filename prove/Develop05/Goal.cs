public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public int _points;


    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool isComplete();
    
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();

    public string GetCompletionStatus()
    {
        return isComplete() ? "[X]" : "[ ]";
    }
}