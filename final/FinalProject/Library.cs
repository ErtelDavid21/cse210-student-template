using System;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.ComponentModel;

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

    public void saveLibrary()
    {
        Console.WriteLine("What do you want to save the library as? ");
        string libraryName = Console.ReadLine();
        using (var writer = new StreamWriter(libraryName))
        {
            writer.WriteLine("dvds: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("vhs: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("ebooks: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("physical books: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("video games: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("card games: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("board games: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            writer.WriteLine("music: ");
            foreach (var item in dvds)
            {
                    writer.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}");
            }
            
       }

    }


    public void loadLibrary(string filesave)
    {
        Console.WriteLine("What file would you like to load into the library? (ex. library1.txt)");
        string libraryFile = Console.ReadLine();

        var lists = new Dictionary<string, List<(string, string, string)>>();
        var currentListName = "";
        var currentList = new List<(string, string, string)>();
        foreach (var line in File.ReadLines(libraryFile))
        {
            if (line.StartsWith("dvds: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "dvds: "

            }
            else if (line.StartsWith("vhs: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "vhs: "
                
            }
            else if (line.StartsWith("ebooks: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "ebooks: "
                
            }
            else if (line.StartsWith("physical books: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "physical books: "
                
            }
            else if (line.StartsWith("video games: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "video games: "
                
            }
            else if (line.StartsWith("card games: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "card games: "
                
            }
            else if (line.StartsWith("board games: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "board games: "
                
            }
            else if (line.StartsWith("music: "))
            {
                if (currentListName != "")
                {
                    lists[currentListName] = currentList;

                    currentList = new List<(string, string, string)>();
                }
                currentListName = line.Substring(5); //Remove "music: "
                
            }
            else
            {
                var parts = line.Split(',');

                currentList.Add((parts[0], parts[1], parts[2]));
            }

            if (filesave.ToLower() == "dvd"){
                dvds.AddRange(lists["dvds: "]);
            }
            else if (filesave.ToLower() == "vhs"){
                vhs.AddRange(lists["vhs: "]);
            }
            else if (filesave.ToLower() == "ebook"){
                eBook.AddRange(lists["ebooks: "]);
            }
            else if (filesave.ToLower() == "pbook"){
                physcialBook.AddRange(lists["physical books: "]);
            }
            else if (filesave.ToLower() == "vgame"){
                videoGame.AddRange(lists["video games: "]);
            }
            else if (filesave.ToLower() == "cgame"){
                cardGame.AddRange(lists["card games: "]);
            }
            else if (filesave.ToLower() == "bgame"){
                boardGame.AddRange(lists["board games: "]);
            }
            else if (filesave.ToLower() == "music"){
                music.AddRange(lists["music: "]);
            }
            else
            {
                Console.WriteLine("Invalid Entry. Try again.");
            }
            
        }
        
            

    }


}

