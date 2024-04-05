public abstract class Activity
{
    private string _date;
    protected int _length;

    public Activity (string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummaty()
    {
        return $"{_date} {this.GetType()} ({_length} min) - Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km" ;
    }

}