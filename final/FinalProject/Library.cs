using System;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class Library
{

    // A list of info
    protected List<string> deLibrary = new List<string>();


    // A list of all the strings
    protected List<(string, string, string)> boardGame = new List<(string, string, string)>();
    protected List<(string, string, string)> cardGame = new List<(string, string, string)>();
    protected List<(string, string, string)> videoGame = new List<(string, string, string)>();
    protected List<(string, string, string)> dvds = new List<(string, string, string)>();
    protected List<(string, string, string)> vhs = new List<(string, string, string)>();
    protected List<(string, string, string)> physcialBook = new List<(string, string, string)>();
    protected List<(string, string, string)> eBook = new List<(string, string, string)>();
    protected List<(string, string, string)> music = new List<(string, string, string)>();

    protected List<(string, string, string)> mediaList = new List<(string, string, string)>();



    protected string title, author, company, creator, newTitle, oldTitle;
    protected string oldCreator, newCreator, oldLocation, newLocation;
    //Load info
    protected string deEbook;
    protected string dePbook;
    protected string deLocale;
    protected string deOldMovieStudio;
    protected string deNewMovieStudio;
    protected string deComposer;
    protected string deGaming;

    public void Display_Info(string information)
    {   
        List<(string, string, string)> mediaIdentify = new List<(string, string, string)>();
        switch (information)
        {
            case "1":
                mediaIdentify = dvds;
                break;
            case "2":
                mediaIdentify = vhs;
                break;
            case "3":
                mediaIdentify = eBook;
                break;
            case "4":
                mediaIdentify = physcialBook;
                break;
            case "5":
                mediaIdentify = videoGame;
                break;
            case "6":
                mediaIdentify = cardGame;
                break;
            case "7":
                mediaIdentify = boardGame;
                break;
            case "8":
                mediaIdentify = music;
                break;
            default:
                break;

        }


        foreach (var details in mediaIdentify)
        {
            Console.WriteLine(details);
        }
        
    }

    
    

    public string addMedia(string mediaType)
    {
        Console.WriteLine("Enter the title of the "+mediaType);
        title = Console.ReadLine();

        return title;       

    }

    public string addAuthor(string mediaType)
    {
        Console.WriteLine("Enter the title of the "+mediaType);
        author = Console.ReadLine();
        
        return author;

    }

    public string addCompany(string mediaType)
    {
        Console.WriteLine("Enter the title of the "+mediaType);
        company = Console.ReadLine();
        
        return company;

    }

    public string addCreator(string mediaType)
    {
        Console.WriteLine("Enter the title of the "+mediaType);
        creator = Console.ReadLine();
        
        return creator;

    }

    public void alterList()
    {
        Console.WriteLine("What do you want to alter? (Enter 1: Title, 2: Source, 3: Location)");
        string alter = Console.ReadLine();
        if (alter == "1")
        {
            Console.WriteLine("What title do you want to change? ");
            oldTitle = Console.ReadLine();
            Console.WriteLine("What is the new title? ");
            newTitle = Console.ReadLine();
        }
        if (alter == "2")
        {
            Console.WriteLine("What Source do you want to change? ");
            oldCreator = Console.ReadLine();
            Console.WriteLine("What is the new Source? ");
            newCreator = Console.ReadLine();
        }
        if (alter == "3")
        {
            Console.WriteLine("What Location do you want to change? ");
            oldLocation = Console.ReadLine();
            Console.WriteLine("What is the new Location? ");
            newLocation = Console.ReadLine();
        }

        mediaList = dvds;

        for (int i = 0; i < mediaList.Count; i++)
        {
            var item = mediaList[i];
            if (item.Item1 == oldTitle){
                mediaList[i] = (newTitle, item.Item2, item.Item3);
            }
            else if (item.Item2 == oldCreator){
                mediaList[i] = (item.Item1, newCreator, item.Item3);
            }
            else if (item.Item3 == oldLocation){
                mediaList[i] = (item.Item1, item.Item2, newLocation);
            } 
        } 
    }

}


    

    