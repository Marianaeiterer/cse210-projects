public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming (string date, int length, double numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 0.05;
        return (distance * 50) / 1000;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override double GetSpeed()
    {
        return  60 / GetPace();
    }

}