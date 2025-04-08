using System;
using System.Formats.Asn1;
using System.Reflection;
using Microsoft.VisualBasic;

class Menu
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

    public void runMenu(int task)
    {
        if (task == 1)
        {
            // Run Display
            Console.WriteLine("What Info would you like to display? ");
            Console.WriteLine("(1. DVDs, 2. VHS, 3. Ebooks, 4. Physical Books, 5. Video Games,");
            Console.WriteLine("6. Card Games, 7. Board Games, 8. Music, 9. All Media)");
            string info = Console.ReadLine();
            

            switch (info)
            {
                case "1": 
                    Console.WriteLine("Displaying DVDs. ");
                    Dvd.Display_Info(info);
                    break;
                case "2":
                    Console.WriteLine("Displaying VHS. ");
                    Vhs.Display_Info(info);
                    break;
                case "3":
                    Console.WriteLine("Displaying Ebooks. ");
                    Digital.Display_Info(info);
                    break;
                case "4":
                    Console.WriteLine("Displaying Physical Books. ");
                    Physical.Display_Info(info);
                    break;
                case "5":
                    Console.WriteLine("Displaying Video Games. ");
                    Vgame.Display_Info(info);
                    break;
                case "6":
                    Console.WriteLine("Displaying Card Games. ");
                    Cgame.Display_Info(info);
                    break;
                case "7":
                    Console.WriteLine("Displaying Board Games. ");
                    Bgame.Display_Info(info);
                    break;
                case "8":
                    Console.WriteLine("Displaying Music. ");
                    Sounds.Display_Info(info);
                    break;
                case "9":
                    Console.WriteLine("Displaying All Files. ");
                    Dvd.Display_Info(info);
                    Vhs.Display_Info(info);
                    Digital.Display_Info(info);
                    Physical.Display_Info(info);
                    Vgame.Display_Info(info);
                    Cgame.Display_Info(info);
                    Bgame.Display_Info(info);
                    Sounds.Display_Info(info);
                    break;
                default:
                    Console.WriteLine("Command not Recognized");
                    break;
            }

            
        }
        if (task == 2)
        {
            // Run Add Info
            Console.WriteLine("What Info would you like to add to? ");
            Console.WriteLine("(1. DVDs, 2. VHS, 3. Ebooks, 4. Physical Books,");
            Console.WriteLine("5. Video Games, 6. Card Games, 7. Board Games, 8. Music)");
            string info = Console.ReadLine();
            switch (info)
            {
                case "1": 
                    Console.WriteLine("Adding to DVDs. ");
                    Add_Info("dvd");
                    break;
                case "2":
                    Console.WriteLine("Adding to VHS. ");
                    Add_Info("vhs");
                    break;
                case "3":
                    Console.WriteLine("Adding to Ebooks. ");
                    Add_Info("ebook");
                    break;
                case "4":
                    Console.WriteLine("Adding to Physical Books. ");
                    Add_Info("physical book");
                    break;
                case "5":
                    Console.WriteLine("Adding to Video Games. ");
                    Add_Info("video game");
                    break;
                case "6":
                    Console.WriteLine("Adding to Card Games. ");
                    Add_Info("card game");
                    break;
                case "7":
                    Console.WriteLine("Adding to Board Games. ");
                    Add_Info("board game");
                    break;
                case "8":
                    Console.WriteLine("Adding to Music. ");
                    Add_Info("music");
                    break;
                default:
                    Console.WriteLine("Command not Recognized");
                    break;
            }
        }
        if (task == 3)
        {
            // Run Alter Info
        }
        if (task == 4)
        {
            // Run Save Info
            Dvd.saveLibrary();
        }
        if (task == 5)
        {
            // Run Load Info
            Console.WriteLine("Do you want to load all info into current lirary? yes or no");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Dvd.loadLibrary("dvd");
                Vhs.loadLibrary("vhs");
                Digital.loadLibrary("ebook");
                Physical.loadLibrary("pbook");
                Vgame.loadLibrary("vgame");
                Cgame.loadLibrary("cgame");
                Bgame.loadLibrary("bgame");
                Sounds.loadLibrary("music");

            }
            if (answer.ToLower() == "no")
            {
                Boolean valid = false;
                while (valid != true)
                {
                    Console.WriteLine("What list would you like to load? ");
                    Console.WriteLine("(1. dvd, 2. vhs, 3. ebook, 4. pbook, 5. vgame, 6. cgame, 7. bgame, 8. music)");
                    answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            Dvd.loadLibrary("dvd");
                            valid = true;
                            break;
                        case "2":
                            Vhs.loadLibrary("vhs");
                            valid = true;
                            break;
                        case "3":
                            Digital.loadLibrary("ebook");
                            valid = true;
                            break;
                        case "4":
                            Physical.loadLibrary("pbook");
                            valid = true;
                            break;
                        case "5":
                            Vgame.loadLibrary("vgame");
                            valid = true;
                            break;
                        case "6":
                            Cgame.loadLibrary("cgame");
                            valid = true;
                            break;
                        case "7":
                            Bgame.loadLibrary("bgame");
                            valid = true;
                            break;
                        case "8":
                            Sounds.loadLibrary("music");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    
                    }
                }
            }    
        }
        {
            Console.WriteLine("That task is not possible");
        }
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
            case "vhs": title = Vhs.addMedia(mediaType);
                        creator = Vhs.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Vhs.saveMedia(title,creator,location);
                break;
            case "music": title = Sounds.addMedia(mediaType);
                        creator = Sounds.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Sounds.saveMedia(title,creator,location);
                break;
            case "ebook": title = Digital.addMedia(mediaType);
                        creator = Digital.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Digital.saveMedia(title,creator,location);
                break;
            case "physical book": title = Physical.addMedia(mediaType);
                        creator = Physical.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Physical.saveMedia(title,creator,location);
                break;
            case "video game": title = Vgame.addMedia(mediaType);
                        creator = Vgame.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Vgame.saveMedia(title,creator,location);
                break;
            case "board game": title = Bgame.addMedia(mediaType);
                        creator = Bgame.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Bgame.saveMedia(title,creator,location);
                break;
            case "card game": title = Cgame.addMedia(mediaType);
                        creator = Cgame.addCompany(mediaType);
                        location = Place.addLocation(mediaType);
                        Cgame.saveMedia(title,creator,location);
                break;

            default: Console.WriteLine("Not a valid media type");
                break;
        }

        
    }
    
    
    

    
}
