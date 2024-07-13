using System;

class Ebooks:Library
{

    public List<string> deauthor = new List<string>();
    public List<string> detitle = new List<string>();

    //Method to get list of companies who made the title
    public List<string> deSetAuthors(string deinfo)
    {
        
        deauthor.Add(deinfo);
        return deauthor;
    }

    //Method to list titles
    public List<string> deSetTitles(string delist)
    {
        
        detitle.Add(delist);

        return detitle;
    }

    //Tell the Authors
    public void deGetAuthors()
    {
        Console.WriteLine("Do you want the full list or an individual point? (1:Full, 2:Individual)");
        string deshow = Console.ReadLine();
        int depoints = Convert.ToInt32(deshow);

        if (depoints == 1)
        {
            Console.WriteLine("The list of Authors is ",deauthor);
        }
        if (depoints == 2)
        {
            Console.WriteLine("What point in the list do you want to find?");
            string delistPoint = Console.ReadLine();
            int defound = Convert.ToInt32(delistPoint);

            Console.WriteLine("The author listed at point ",defound," is ",deauthor[defound]);
        }
        else
        {
            Console.WriteLine("That point doesn't exist.");
        }
    }
}