using System;
using System.Reflection;
using Microsoft.VisualBasic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("This is the final Project");
        Boolean deActivate = true;
        do
        {
            Console.WriteLine("Do you want to open up your library? (yes or no)");
            string deOpen = Console.ReadLine();
        

            // Determine if the Library is being used
            if (deOpen.ToLower() == "yes")
            {
                //start the library
                Library deUser = new Library();
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1: Display Info, 2: Add Info, 3. Alter Info)");

                string deTask = Console.ReadLine();
                int deChoice = Convert.ToInt32(deTask);
                int deToDo = 0;

                if (deChoice >= 1 || deChoice <= 3)
                {
                    deToDo = deChoice;
                }

                deUser.deStartLibrary(deToDo);

                
            }
            if (deOpen.ToLower() == "no")
            {
                //Quits the program

                Console.WriteLine("You have chosen to exit, have a good day");
                deActivate = false;
            }
            else
            {
                Console.WriteLine("Unrecognized input, please try again.");

            }
        }while (deActivate == true);
    }
    
        
    


    
    
}


/*Book Library

phrsical books
location
ebooks
movies
music
etc.*/
