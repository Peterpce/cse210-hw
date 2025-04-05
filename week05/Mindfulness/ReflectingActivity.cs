public class ReflectionActivity : Activity
{
    private static List<string> _unusedPrompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity helps you reflect on moments of strength and resilience.") { }

    protected override void PerformActivity(int duration)
    {
        if (_unusedPrompts.Count == 0) _unusedPrompts.AddRange(_questions);

        Random random = new();
        string prompt = _unusedPrompts[random.Next(_unusedPrompts.Count)];
        _unusedPrompts.Remove(prompt);

        Console.WriteLine($"\n{prompt}");
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine($"\n{_questions[random.Next(_questions.Count)]}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}