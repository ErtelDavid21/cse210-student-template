using System;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class Program
{


    public static void Main()
    {

        Menu order = new Menu();
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
                
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1: Display Info, 2: Add Info, 3. Alter Info, 4. Save Info, 5, Load Info)");

                int deTask = Convert.ToInt32(Console.ReadLine());
                order.runMenu(deTask);

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