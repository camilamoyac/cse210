public class BikingActivity : Activity
{
    private float _speed;

    public BikingActivity(DateTime date, double length, float speed) : base(date, length, "Biking")
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}