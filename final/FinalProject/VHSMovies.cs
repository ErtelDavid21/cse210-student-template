using System;

class VHSMovies:Library
{
    public void saveMedia(string title, string company, string location)
    {
        vhs.Add((title, company, location));
        
    }
}