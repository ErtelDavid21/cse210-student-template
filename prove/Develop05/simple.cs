using System;
using System.Collections.Generic;

public class Simple
{
    private List<Goal> goals;

    public Simple()
    {
        goals = new List<Goal>
        {
            new Goal { Name = "Run a Marathon", Points = 1000, IsComplete = false },
            new Goal { Name = "Study Scriptures", Points = 500, IsComplete = false },
            new Goal { Name = "Finish a Project", Points = 800, IsComplete = false },
            new Goal { Name = "Go for a walk", Points = 100, IsComplete = false }
        };
    }

    public void MarkGoalAsComplete(string name)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == name)
            {
                goal.IsComplete = true;
                Console.WriteLine($"Congratulations! You've completed the goal: {name} and earned {goal.Points} points.");
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"Goal: {goal.Name}, Points: {goal.Points}, IsComplete: {goal.IsComplete}");
        }
    }
}
