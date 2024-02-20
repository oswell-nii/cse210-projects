class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed} mph, Pace: {GetPace()} min per mile";
    }
}