using System.Globalization;

public abstract class Activity
{
    protected DateTime _date;
    protected double _length;
    protected string _name;

    public Activity(DateTime date, double length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture)} {_name} ({_length} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
    }

}