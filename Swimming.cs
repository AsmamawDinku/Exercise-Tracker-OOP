// Derived class representing a swimming activity.
// Calculates distance from number of laps, assumes 50 meters per lap.

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0; // meters to km
    public override double GetSpeed() => GetDistance() / GetLength() * 60;
    public override double GetPace() => GetLength() / GetDistance();
}
