using System;

class VideoGame:Library
{
    public List<string> deCompany = new List<string>();
    List<string> deGames = new List<string>();

    //Method to get list of companies who made the games
    public List<string> deGetCompany(string deInfo)
    {
        
        deCompany.Add(deInfo);
        return deCompany;
    }

    //Method to get video game names
    public List<string> deGetGameNames(string deList)
    {
        
        deGames.Add(deList);

        return deGames;
    }
}