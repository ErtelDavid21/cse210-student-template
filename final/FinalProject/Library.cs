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
    //Load info
    protected string deEbook;
    protected string dePbook;
    protected string deLocale;
    protected string deOldMovieStudio;
    protected string deNewMovieStudio;
    protected string deComposer;
    protected string deGaming;


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

    public void addCompany(string mediaType)
    {
        Console.WriteLine("Enter the title of the "+mediaType);
        title = Console.ReadLine();
        

    }

    public void addCreator(string mediaType)
    {
        Console.WriteLine("Enter the title of the "+mediaType);
        title = Console.ReadLine();
        

    }

    public void alterTitle()
    {
        Console.WriteLine("What do you want to alter? (Enter 1: Title, 2: Source, 3: Location)");
        string alter = Console.ReadLine();
        string placement = alter;
        if (alter == "1")
        {
            Console.WriteLine("What title do you want to change? ");
            oldTitle = Console.ReadLine();
            Console.WriteLine("What is the new title? ");
            newTitle = Console.ReadLine();
        }
        mediaList = dvds;

        for (int i = 0; i < mediaList.Count; i++)
        {
            var item = mediaList[i];
            if (placement == "1"){
                mediaList[i] = (i == 0 ? oldTitle : newTitle, item.Item2, item.Item3);
            }
            else if (placement == "2"){
                mediaList[i] = (item.Item1, i == 0 ? oldCreator : newCreator, item.Item3);
            }
            else if (placement == "3"){
                mediaList[i] = (item.Item2, item.Item3, i == 0 ? oldLocation : newLocation);
            } 
        } 
    }

}


    

    