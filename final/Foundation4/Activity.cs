public abstract class Activity
{
    private string _date;
    protected float _length;

    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }
    
    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
    public string GetSummary()
    {
        var activityType = GetType().Name;
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = CalculatePace();

        return $"{_date} {activityType} ({_length} min): Distance {Math.Round(distance, 1)} miles, Speed {Math.Round(speed, 1)} mph, Pace {Math.Round(pace, 1)} min per mile";
    }
}