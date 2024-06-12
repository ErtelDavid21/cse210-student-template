using System;
using System.Net;

class Goal
{
    public void Goals()
    {
        Boolean decontinue = true;
        do
        {
            Console.WriteLine("What would you like to do? 0: quit");
            string deactivity = Console.ReadLine();

            // Quits the loop if the user selected quit.
            if (deactivity == "0")
            {
                decontinue = false;


            }
            else
            {
                decontinue = true;
            }
        }while(decontinue != false);
    }

    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }
}