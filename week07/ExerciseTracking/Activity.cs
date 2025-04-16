public abstract class Activity
{
    protected DateTime date;
    protected int duration; 
    
    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    
    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    
    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({duration} min): Distance {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0} min per { (this is Running ? "mile" : "km") }";
    }
}
