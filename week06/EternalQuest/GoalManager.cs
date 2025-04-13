using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; private set; } = new List<Goal>();
    public int Score { get; private set; } = 0;

    public void AddGoal(Goal goal) => Goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            Score += Goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].GetStatus()} {Goals[i].Name} ({Goals[i].Description})");
        }
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(Score);
        foreach (Goal goal in Goals)
        {
            writer.WriteLine(goal.GetSaveString());
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename)) return;

        Goals.Clear();
        using StreamReader reader = new StreamReader(filename);
        Score = int.Parse(reader.ReadLine());
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) sg.RecordEvent();
                    Goals.Add(sg);
                    break;
                case "EternalGoal":
                    Goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    for (int i = 0; i < int.Parse(parts[6]); i++) cg.RecordEvent();
                    Goals.Add(cg);
                    break;
            }
        }
    }

    public void DisplayScore() => Console.WriteLine($"Your current score is: {Score}");
}
