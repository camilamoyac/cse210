public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, double length, int laps) : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}