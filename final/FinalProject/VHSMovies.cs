using System;

class VHSMovies:Library
{
    public List<string> deCompany = new List<string>();
    public List<string> deVHSmovies = new List<string>();

    //Method to get list of companies who made the movies
    public List<string> deAddCompanyInfo(string deInfo)
    {
        
        deCompany.Add(deInfo);
        return deCompany;
    }

    //Method to get video game names
    public List<string> deAddMovies(string deList)
    {
        
        deVHSmovies.Add(deList);

        return deVHSmovies;
    }
}