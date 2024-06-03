public class Running : Activity
{
    private float _distance;

    public Running(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculatePace()
    {
        return _length / _distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / _length * 60;
    }
}