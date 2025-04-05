public class ListingActivity : Activity
{
    private static List<string> _unusedPrompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you appreciate the good things in life by listing them.") { }

    protected override void PerformActivity(int duration)
    {
        if (_unusedPrompts.Count == 0) _unusedPrompts.AddRange(_unusedPrompts);

        Random random = new();
        string prompt = _unusedPrompts[random.Next(_unusedPrompts.Count)];
        _unusedPrompts.Remove(prompt);

        Console.WriteLine($"\n{prompt}");
        ShowSpinner(3);

        int count = 0;
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
            elapsed += 2;
        }
        Console.WriteLine($"\nYou listed {count} items!");
    }
}

