class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_minutes} min)";
    }
}