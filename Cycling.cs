// Derived class representing a cycling activity.
// Calculates distance using speed and time.

public class Cycling : Activity
{
    private double _speed; // in kilometers per hour

    public Cycling(string date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * GetLength()) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;
}
