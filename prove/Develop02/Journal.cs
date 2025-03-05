/* 
CSE210

Journal Menu
Journal Entry System
Navigate
Inputs: Write, Read, Load, Quit
Outputs: Declare which input was accepted

David Ertel
(c)2023
*/

using System;

class Journal
{
    public Boolean journalLoad(Boolean journalTask)
    {
        // Initializes the variables to run the journal
        Entry e = new Entry();
        PromptGenerator p = new PromptGenerator(); 
        List<string> JournalEntries = new List<string>();
        
        // Ask for what the user would like to do.
        Console.WriteLine("What would you like to do?");

        // Give options for the user to choose
        Console.WriteLine("Type in: Write, Read, Load, Save, or Quit");

        //Obtain the users input
        string userRequest = Console.ReadLine();
        
        
        // Sort what request the user wants to do.

        // Quit the Program
        if (userRequest.ToLower() == "quit")
        {
            Console.WriteLine("You have chosen to exit, come back soon.");
            journalTask = false;
            return journalTask;
            
        }

        // Write a new entry
        else if (userRequest.ToLower() == "write")
        {
            Console.WriteLine("Want a random prompt? (y/n)");
            string prompting = Console.ReadLine();
            Entry user = new Entry();
            PromptGenerator prompter = new PromptGenerator();
            
            if (prompting.ToLower() == "y")
            {
                prompter.Prompt();
            }
            else
            {
                Console.WriteLine("No Prompt was generated.");
            }
            e.journalEntry();

            JournalEntries.Add();

        }

        // Save the entries given to a txt file
        else if (userRequest.ToLower() == "save")
        {
            Console.WriteLine("What would you like to name the Journal Entries file? ");
            string title = Console.ReadLine();

            File.WriteAllLines();

        }

        // Read the current entries you have written
        else if (userRequest.ToLower() == "read")
        {
            Console.WriteLine("You have chosen to read entries");
        }

        else if (userRequest.ToLower() == "load")
        {
            Console.WriteLine("You have chosen to load a different Journal, enter in the journal name and location.");
            string loadJournal = Console.ReadLine();
        
        }

        // Failsafe to make sure user chooses 1 of the 5 valid inputs.
        else
        {
            Console.WriteLine("Input invalid, try again");

        }

        return "";
    }


    
}