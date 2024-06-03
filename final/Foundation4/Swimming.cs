using System.IO.Pipes;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, float length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return 0.62 * _laps * 50 / 1000;
    }
    public override double CalculatePace()
    {
        double swimDist = CalculateDistance();
        return _length / swimDist;
    }
    public override double CalculateSpeed()
    {
        double swimDist = CalculateDistance();
        return (swimDist / _length) * 60;
    }
}