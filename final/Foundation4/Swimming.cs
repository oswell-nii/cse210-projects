class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_minutes / 60.0); // Speed in miles per hour
    }

    public override double GetPace()
    {
        return _minutes / GetDistance(); // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}