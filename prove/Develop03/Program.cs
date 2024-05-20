using System;

class Program
{
    static void Main(string[] args)
    {   
        //Start by asking what the user wants to memorize
        Console.WriteLine("Please enter what you would like to study.");
        string studyMaterial = Console.ReadLine();
        
    
        
        
        Scripture learn = new Scripture();
        learn.Referring();
        
        Boolean truth = false;
        do
        {
            Console.WriteLine(learn.HideWords);
            Console.WriteLine("Enter 'quit' to end.");
            string DEinput = Console.ReadLine();
            if (DEinput.ToLower() == "quit")
            {
                truth = true;
            }
            
        } while (! truth);
        
        Console.WriteLine("You have finished, have a nice day.");
        
    }
}

/*
int i;
bool valid = false;
do {
    Console.WriteLine("Enter an int: ");
    string input = Console.ReadLine();
    valid = int.TryParse(input, out i);
} while(! valid);
*/