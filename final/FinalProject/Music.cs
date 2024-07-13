using System;

class Music:Library
{
    //Method to get artist list
    public List<string> deGetArtist(string deInfo)
    {
        List<string> deCreator = new List<string>();
        deCreator.Add(deInfo);
        return deCreator;
    }

    //Method to get song names
    public List<string> deGetSongNames(string deNames)
    {
        List<string> deSongs = new List<string>();
        deSongs.Add(deNames);

        return deSongs;
    }
}