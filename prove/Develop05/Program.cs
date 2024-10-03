using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Game!");

        Console.WriteLine("Would you like to play? (1 Yes, 0 No)");
        string deplay = Console.ReadLine();
        int deconvert = Convert.ToInt32(deplay);

        if (deconvert == 1)
        {
            Goal degoals = new Goal();
            degoals.Goals(); 

        }
        else 
        {
            Console.WriteLine("You hare selected to Quit. Goodbye! ");
        }

        var simple = new Simple();
        simple.DisplayGoals();
        simple.MarkGoalAsComplete("Run a Marathon");
        simple.DisplayGoals();
        
    
    }
}