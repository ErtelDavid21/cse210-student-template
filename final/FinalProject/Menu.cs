using System;
using System.Reflection;
using Microsoft.VisualBasic;

class Menu
{

    public int taskMenu(int task)
    {
        
        
        if (task == 1)
        {
            Console.WriteLine("You want to see the Library info");
            return task;
        }
        if (task == 2)
        {
            Console.WriteLine("You want to add info to your Library");
            return task;
        }
        if (task == 3)
        {
            Console.WriteLine("You want to change info given");
            return task;
        }
        else
        {
            Console.WriteLine("You have chosen a task that doesn't exist");
            return task;
        }

    }

    public void GetLibrary()
    {
        Console.WriteLine("");
    }

    public void SetLibrary()
    {
        Console.WriteLine("What would you like to add too?");
        Console.WriteLine("(1: Ebook, 2: Physical Book, 3: Location, 4: DVDs,");
        Console.WriteLine("5: VHS, 6: Music, 7: Video game");
        string addInfo = Console.ReadLine();
        int addTo = Convert.ToInt32(addInfo);

        if (addTo <=3 || addTo >=1)
        {
            // only cares about the inputs 1 to 3
            if (addTo == 1)
            {
                
                //call to Ebook info creator

                //Set ebook Author info
                Console.WriteLine("Who is the Author of the ebook?");
                deEbook = Console.ReadLine();
                deDigital.deSetAuthors(deEbook);

                //Set Title for ebook
                Console.WriteLine("What is the Title of the ebook?");
                deEbook = Console.ReadLine();
                deDigital.deSetTitles(deEbook);

                //Set location for ebook
                Console.WriteLine("Where is the ebook stored?");
                deLocale = Console.ReadLine();
                dePlace.deSetLocation(deLocale);
            }
            if (addTo == 2)
            {
                //call to Physical book info creator
                Console.WriteLine("Who is the Author of the ebook?");
                dePbook = Console.ReadLine();
                deDigital.deSetAuthors(dePbook);
                Console.WriteLine("What is the Title of the ebook?");
                dePbook = Console.ReadLine();
                deDigital.deSetTitles(dePbook);

                //Set location for book
                Console.WriteLine("Where is the book stored?");
                deLocale = Console.ReadLine();
                dePlace.deSetLocation(deLocale);

            }
            else
            {
                // call to location info creator
                //Set location for ebook
                Console.WriteLine("What ");
                deLocale = Console.ReadLine();
                dePlace.deSetLocation(deLocale);
            }
        }
        if (addTo <=7 || addTo >=4)
        {
            // only cares about the inputs from 4 to 7
        }
    }

    

    public void DisplayInfo()
    {
        // Asks the user what they want to see and displays it
        Console.WriteLine("What info do you want displayed?");
        Console.WriteLine("(Author, Location, Movie Studio, Artist, Game Company)");

        string info = Console.ReadLine();

        if (info.ToLower() == "author")
        {
            // Calls author info from Ebooks.cs and PhysicalBooks.cs
            deDigital.deGetAuthors();
            List<string> dePAuthor = dePhysical.deGetAuthor(dePbook);
            Console.WriteLine("The Authors are: "," ",dePAuthor);
            
        }
        if (info.ToLower() == "location")
        {
            // Calls Storage location info from Location.cs
            List<string> setting = dePlace.deGetLocation(deLocale);
            Console.WriteLine("The Locations are: ",setting);
            
        }
        if (info.ToLower() == "movie studio")
        {
            // Calls Movie Creator info from DVDMovies.cs and VHSMovies.cs
            List<string> deNewMovies = deDvd.deSetCompany(deNewMovieStudio);
            List<string> deOldMovies = deDvd.deSetCompany(deOldMovieStudio);
            Console.WriteLine("The Movie Studios you have movies from are: ");
        }
        if (info.ToLower() == "artist")
        {
            // Calls Artist info from Music.cs
            List<string> deArtist = deSounds.deGetArtist(deComposer);
        }
        if (info.ToLower() == "game company")
        {
            // Calls Video Game info from VideoGame.cs
            List<string> deConsole = deGame.deGetCompany(deGaming);
        }
        else
        {
            // Not a valid input, so it doesn't go anywhere
            Console.WriteLine("The response given does not exist");
            Console.WriteLine("Would you like to try again?");
            
        }

    }
}
