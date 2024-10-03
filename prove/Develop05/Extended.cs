using System;


class Extended: Goal
{
    public string[] ExtendedGoals(string[] deextendedGoals)
    {
        //Get a new extended goal
        Console.WriteLine("What is the goal you would like to add?");
        string degoalAdd = Console.ReadLine();

        //Get amount of repeat times
        Console.WriteLine("How many times do you want to repeat this goal?");
        string degoalRepeat = Console.ReadLine();

        // Add goal and repeat number to Extended Goal List
        string[] degoal = {degoalAdd};
        string[] derepeat = {degoalRepeat};

        string[] degoalList = deextendedGoals.Concat(degoal).ToArray();
        degoalList = deextendedGoals.Concat(derepeat).ToArray();

        // needs to change return type or delete this statement
        return degoalList;

    }
}

//deThisIsTheWay
