public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, double length, double distance) : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}