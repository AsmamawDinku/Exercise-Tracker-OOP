// Derived class representing a running activity.
// Calculates distance based on user input and derives speed and pace from it.

public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(string date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / GetLength()) * 60;
    public override double GetPace() => GetLength() / _distance;
}
