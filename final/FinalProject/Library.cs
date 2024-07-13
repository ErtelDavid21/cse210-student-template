using System;
using System.Reflection.Metadata;

class Library
{

    // A list of info
    protected List<string> deLibrary = new List<string>();

    // Set up variables to call to each class
    private Ebooks deDigital         = new Ebooks();
    private PhysicalBooks dePhysical = new PhysicalBooks();
    private Location dePlace         = new Location();
    private DVDMovies deDvd          = new DVDMovies();
    private VHSMovies deVhs          = new VHSMovies();
    private VideoGame deGame         = new VideoGame();
    private Music deSounds           = new Music();

    //Load info
    protected string deEbook;
    protected string dePbook;
    protected string deLocale;
    protected string deOldMovieStudio;
    protected string deNewMovieStudio;
    protected string deComposer;
    protected string deGaming;



    

    public int deStartLibrary(int deTask)
    {
        
        
        if (deTask == 1)
        {
            Console.WriteLine("You want to see the Library info");
            return deTask;
        }
        if (deTask == 2)
        {
            Console.WriteLine("You want to add info to your Library");
            return deTask;
        }
        if (deTask == 3)
        {
            Console.WriteLine("You want to change info given");
            return deTask;
        }
        else
        {
            Console.WriteLine("You have chosen a task that doesn't exist");
            return deTask;
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
