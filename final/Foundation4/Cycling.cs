public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double _time = _length / 60;
        return _time * _speed;
    }
    public override double CalculatePace()
    {
        double cycleDist = CalculateDistance();
        return _length/cycleDist;
    }
    public override double CalculateSpeed()
    {  
        double cycleDist = CalculateDistance();
        return (cycleDist/_length) * 60;
    }
}