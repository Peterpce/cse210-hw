using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string input;

        // Helper method for getting valid integer input
        int GetValidInt(string prompt)
        {
            int result;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            return result;
        }

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Select Goal Type:\n1. Simple\n2. Eternal\n3. Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    int pts = GetValidInt("Points: ");

                    if (type == "1")
                        manager.AddGoal(new SimpleGoal(name, desc, pts));
                    else if (type == "2")
                        manager.AddGoal(new EternalGoal(name, desc, pts));
                    else if (type == "3")
                    {
                        int target = GetValidInt("Target count: ");
                        int bonus = GetValidInt("Bonus: ");
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                    }
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.DisplayGoals();
                    int goalNum = GetValidInt("Enter goal number to record: ") - 1;
                    manager.RecordEvent(goalNum);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "5":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "6":
                    manager.DisplayScore();
                    break;
            }
        } while (input != "0");
    }
}
