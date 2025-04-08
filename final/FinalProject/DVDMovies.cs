using System;

class DVDMovies:Library
{

    public List<string> Company = new List<string>();
    public List<string> Movies = new List<string>();


    

    public void saveMedia(string title, string company, string location)
    {
        dvds.Add((title, company, location));
        
    }
}