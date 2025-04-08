using System;

class Ebooks:Library
{

    public List<string> deauthor = new List<string>();
    public List<string> detitle = new List<string>();

    public void saveMedia(string title, string company, string location)
    {
        eBook.Add((title, company, location));
        
    }
}