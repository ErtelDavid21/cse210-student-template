using System;

class DVDMovies:Library
{

    public List<string> deCompany = new List<string>();
    public List<string> deMovies = new List<string>();

    //Method to get list of companies who made the movies
    public List<string> deSetCompany(string deInfo)
    {
        
        deCompany.Add(deInfo);
        return deCompany;
    }

    //Method to get movie names
    public List<string> deSetMovies(string deList)
    {
    
        deMovies.Add(deList);

        return deMovies;
    }
}