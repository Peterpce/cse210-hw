class Program
{
    static void Main(string[] args)
    {
        
        Activity run = new Running(new DateTime(2025, 4, 19), 30, 3.0);
        Activity cycle = new Cycling(new DateTime(2025, 4, 19), 30, 12.0);
        Activity swim = new Swimming(new DateTime(2025, 4, 19), 30, 40);

       
        List<Activity> activities = new List<Activity> { run, cycle, swim };

            foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
