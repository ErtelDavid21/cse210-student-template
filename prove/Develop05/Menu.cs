using System;

class Menu
{
    public static void MenuTask()
    {

        Simple single = new Simple();
        Checklist duplicate = new Checklist();
        Eternal forever = new Eternal();


        Boolean decontinue = true;
        do
        {
            Console.WriteLine("What would you like to do? 0: quit");
            Console.WriteLine(" (0: quit, 1: add goal, 2: complete goal, 3: show goals, 4: show points )");
            string deactivity = Console.ReadLine();

            // Quits the loop if the user selected quit.
            if (deactivity == "0")
            {
                decontinue = false;


            }

            // Adds a goal to the list of goals
            else if (deactivity == "1")
            {
                Console.WriteLine("What kind of goal would you like to add? ");
                Console.WriteLine("(1: Simple Goal, 2: Checklist Goal, 3: Eternal Goal)");
                string goalType = Console.ReadLine();
                if (goalType == "1")
                {
                    single.AddGoals("simple");
                }
            }

            // Marks a goal as completed once
            else if (deactivity == "2")
            {
                Console.WriteLine("What kind of goal would you like to add? ");
                Console.WriteLine("(1: Simple Goal, 2: Checklist Goal, 3: Eternal Goal)");
                string goalType = Console.ReadLine();
                if (goalType == "1")
                {
                    single.AddGoals("simple");
                }
            }

            // Displays all the goals currently on the list of goals
            else if (deactivity == "3")
            {
                
            }
            else if (deactivity == "4")
            {
                
            }
            else
            {
                Console.WriteLine("Response not recognized, try again to follow instructions properly");
            }
        }while(decontinue != false);
    }
}