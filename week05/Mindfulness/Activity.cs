public abstract class Activity
{
    private string _name;
    private string _description;
    private static Dictionary<string, int> activityLog = LoadActivityLog();

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start(int duration)
    {
        Console.WriteLine($"\nStarting {_name}...");
        Console.WriteLine(_description);
        Thread.Sleep(2000);
        PerformActivity(duration);
        Console.WriteLine($"\nGreat job! You completed {_name} for {duration} seconds.");
        Thread.Sleep(2000);

        // Log activity
        if (activityLog.ContainsKey(_name))
            activityLog[_name]++;
        else
            activityLog[_name] = 1;
        
        SaveActivityLog();
    }

    protected abstract void PerformActivity(int duration);

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    private static Dictionary<string, int> LoadActivityLog()
    {
        if (File.Exists("activity_log.txt"))
        {
            return File.ReadAllLines("activity_log.txt")
                .Select(line => line.Split(','))
                .ToDictionary(parts => parts[0], parts => int.Parse(parts[1]));
        }
        return new Dictionary<string, int>();
    }

    private static void SaveActivityLog()
    {
        File.WriteAllLines("activity_log.txt", activityLog.Select(kvp => $"{kvp.Key},{kvp.Value}"));
    }

    public static void ShowActivityStats()
    {
        Console.WriteLine("\nActivity Stats:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        Console.WriteLine();
    }
}