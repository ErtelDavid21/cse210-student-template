using System;

class Location:Library
{

    public List<string> deLocal = new List<string>();
    public List<string> deArea = new List<string>();

    //Method to get list of locations
    public List<string> deGetLocation(string deInfo)
    {
         Console.WriteLine("Do you want the full list or an individual point? (1:Full, 2:Individual)");
        string deshow = Console.ReadLine();
        int depoints = Convert.ToInt32(deshow);

        if (depoints == 1)
        {
            Console.WriteLine("The list of Authors is ",deArea);
        }
        if (depoints == 2)
        {
            Console.WriteLine("What point in the list do you want to find?");
            string delistPoint = Console.ReadLine();
            int defound = Convert.ToInt32(delistPoint);

            Console.WriteLine("The author listed at point ",defound," is ",deArea[defound]);
        }
        deLocal.Add(deInfo);
        return deLocal;
    }

    //Method to set location
    public List<string> deSetLocation(string deList)
    {
        
        deArea.Add(deList);

        return deArea;
    }
}