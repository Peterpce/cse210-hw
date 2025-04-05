public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") { }

    protected override void PerformActivity(int duration)
    {
        int elapsed = 0;
        while (elapsed < duration)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"\rBreathe in... {new string('■', i)}");
                Thread.Sleep(500);
            }

            for (int i = 5; i >= 1; i--)
            {
                Console.Write($"\rBreathe out... {new string('■', i)} ");
                Thread.Sleep(500);
            }
            Console.Write("\r                          \r"); // Clear line
            elapsed += 5;
        }
    }
}
