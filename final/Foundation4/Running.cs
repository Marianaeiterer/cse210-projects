public class Running : Activity
{
    private double _distance;

    public Running (string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }

}