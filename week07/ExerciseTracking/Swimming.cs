public class Swimming : Activity
{
    private int laps;
    private const double LapLengthInMeters = 50;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * LapLengthInMeters) / 1000; 

    public override double GetSpeed() => (GetDistance() / duration) * 60; 

    public override double GetPace() => duration / GetDistance(); 
}
