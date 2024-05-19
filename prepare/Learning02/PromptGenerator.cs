using System;

class PromptGenerator
{
    public static void Prompt()
    {

        // randomize a prompt to be given to the user when they load up an entry
        Random rnd = new Random();
        int num = rnd.Next(10);

        switch (num)
        {
            case 0:
                Console.WriteLine("What did you do today? ");
            case 1:
                Console.WriteLine("Did you meet anyone new? ");
            case 2:
                Console.WriteLine("Was there anything special today? ");
            case 3:
                Console.WriteLine("Did you have work or do homework today? ");
            case 4:
                Console.WriteLine("Did you find the love of your life? ");
            case 5:
                Console.WriteLine("Did you play a game today? ");
            case 6:
                Console.WriteLine("Were you embarassed today? ");
            case 7:
                Console.WriteLine("If you were an animal, what would you end up being? ");
            case 8:
                Console.WriteLine("Have you felt the spirit today? ");
            case 9:
                Console.WriteLine("Have you felt a desire to change today? ")
            
        }

        
    }
}