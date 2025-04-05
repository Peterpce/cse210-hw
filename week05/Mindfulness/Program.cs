class Program
{
    static void Main()
    {
        Dictionary<string, Activity> activities = new()
        {
            { "1", new BreathingActivity() },
            { "2", new ReflectionActivity() },
            { "3", new ListingActivity() },
            { "4", new GratitudeJournalActivity() }
        };

        while (true)
        {
            Console.WriteLine("\nMindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Journal");
            Console.WriteLine("5. View Activity Stats");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();
            if (choice == "6") break;
            if (choice == "5") Activity.ShowActivityStats();
            else if (activities.ContainsKey(choice))
            {
                Console.Write("Enter duration in seconds: ");
                if (int.TryParse(Console.ReadLine(), out int duration))
                    activities[choice].Start(duration);
            }
        }
    }
}
