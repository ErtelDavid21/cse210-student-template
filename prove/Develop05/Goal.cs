using System;
using System.Net;

class Goal
{
    private List<(string, string, string, int)> totalGoals = [];
    private List<(string, string, string, int)> simpleGoals = [];
    private List<(string, string, string, int)> checklistGoals = [];
    private List<(string, string, string, int)> eternalGoals = [];

    

    public void DisplayGoals(string goalType)
    {
        List<(string, string, string, int)> showGoals = [];
        if (goalType == "all")
        {
            showGoals = totalGoals;
        }

        foreach (var goal in showGoals)
        {
            Console.WriteLine($"Goal: {goal.Item1}, Points: {goal.Item4}, IsComplete: {goal.Item3}, Goal Type: {goal.Item2}");
        }
    }

    public List<(string, string, string, int)> AddGoals(string type)
    {
        Console.WriteLine("What is the goal you are adding? ");
        string userAdd = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        int userPoints = Convert.ToInt32(Console.ReadLine());

        string goalComplete = "incomplete";

        totalGoals.Add((userAdd, type, goalComplete, userPoints));
        if (type == "simple")
        {
            simpleGoals.Add((userAdd, type, goalComplete, userPoints));
        }
        else if (type == "checklist")
        {
            checklistGoals.Add((userAdd, type, goalComplete, userPoints));
        }
        else if (type == "eternal")
        {
            eternalGoals.Add((userAdd, type, goalComplete, userPoints));
        }

        return totalGoals;


    }

    public void Goals()
    {
        
    }

    private Boolean IsGoalComplete(Boolean task)
    {
        if (task == true){
            Console.WriteLine($"The goal is complete");
            return false;
        }
    }

    
}