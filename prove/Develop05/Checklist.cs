using System;
using System.Globalization;

class Checklist
{
    
    protected string[] merged;

    public void ObtainList(string[] degoalList, string[] depointsList)
    {
        // Display a list of tasks

        int detotalGoal = degoalList.Length;
        int depointAmount = depointsList.Length;
        
        if (detotalGoal == depointAmount)
        {
            merged = new string[degoalList.Length + depointsList.Length];
            merged[0] = degoalList[0];

            for (int i = 1, j = 1; i < degoalList.Length; i++)
            {
                merged[j++] = depointsList[i - 1];
                merged[j++] = degoalList[i];
            }
            
        }
        else
        {
            Console.WriteLine("There is an error, points allotment don't match amount of Goals.");
        }

        
        Console.WriteLine("The current goal list is: "+merged);
    }

    public static void CompletedItems(string[] goals)
    {
        // Pull all the  Completed Goals to here
        
    }

    public static void TotalPoints(string[] points)
    {
        // Pull the points here
    }
}