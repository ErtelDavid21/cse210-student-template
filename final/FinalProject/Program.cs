using System;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class Program
{
    private Ebooks Digital         = new Ebooks();
    private PhysicalBooks Physical = new PhysicalBooks();
    private Location Place         = new Location();
    private DVDMovies Dvd          = new DVDMovies();
    private VHSMovies Vhs          = new VHSMovies();
    private VideoGame Vgame         = new VideoGame();
    private VideoGame Bgame         = new VideoGame();
    private VideoGame Cgame         = new VideoGame();
    private Music Sounds           = new Music();

    public string location;
    public string title;
    public string creator;


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
                
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1: Display Info, 2: Add Info, 3. Alter Info)");

                string deTask = Console.ReadLine();
                int deChoice = Convert.ToInt32(deTask);
                int deToDo = 0;

                if (deChoice >= 1 || deChoice <= 3)
                {
                    deToDo = deChoice;
                }

                

                
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

    public List<string> Display_Info(List<string> information)
    {
        foreach (var details in information)
        {
            Console.WriteLine(details);
        }
        return information;
    }

    public void Add_Info(string mediaType)
    {
        switch (mediaType)
        {
            case "dvd": title = Dvd.addMedia(mediaType);
                        creator = Dvd.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Dvd.saveMedia(title,creator,location);
                break;
            case "vhs": Vhs.addMedia(mediaType);
                        location = Place.addLocation(mediaType);
                break;
            case "music": Sounds.addMedia(mediaType);
                          location = Place.addLocation(mediaType);
                break;
            case "ebook": Digital.addMedia(mediaType);
                          location = Place.addLocation(mediaType);
                break;
            case "physical book": Physical.addMedia(mediaType);
                                  location = Place.addLocation(mediaType);
                break;
            case "video game": Vgame.addMedia(mediaType);
                               location = Place.addLocation(mediaType);
                break;
            case "board game": Bgame.addMedia(mediaType);
                               location = Place.addLocation(mediaType);
                break;
            case "card game": Cgame.addMedia(mediaType);
                              location = Place.addLocation(mediaType);
                break;

            default: Console.WriteLine("Not a valid media type");
                break;
        }

        
    }
    
    






    
}