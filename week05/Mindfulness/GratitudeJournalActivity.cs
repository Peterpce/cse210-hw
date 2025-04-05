partial class GratitudeJournalActivity : Activity
{
    private static readonly string _filePath = "gratitude_log.txt";

    public GratitudeJournalActivity() : base("Gratitude Journal", "This activity allows you to reflect on things you are grateful for.") { }

    protected override void PerformActivity(int duration)
    {
        List<string> entries = new();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Enter something you're grateful for: ");
            entries.Add(Console.ReadLine());
            elapsed += 3;
        }

        File.AppendAllLines(_filePath, entries);
        Console.WriteLine("Gratitude saved!");
    }
}
