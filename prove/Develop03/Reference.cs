using System;

class Reference
{
    public string DEinfo;
    public void referToUser()
    {
        // Asks the user to enter in the reference for what they are studying

        Console.WriteLine("Please Enter the Reference for the Study Material");
        DEinfo = Console.ReadLine();

    }

    public void referToFile()
    {
        // Gets the user to input a txt file to read scriptures from
        Console.WriteLine("Please enter file name from the .txt file type");
        //DEinfo = file.txt
    }

    public void referToGiven()
    {
        Console.WriteLine("You will be given a random scripture");
        Random choice = new Random();
        int num = rnd.Next(10);

        switch (num)
        {
            case 0:
                Console.WriteLine("1 Nephi 2:15 - And my father dwelt in a tent.");
            case 1:
                Console.WriteLine("4 And when ye shall receive these things, I would exhort you that ye would ask God,\n 
                "the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a \n
                sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n
                5 And by the power of the Holy Ghost ye may know the truth of all things.\n
                6 And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");
            case 2:
                Console.WriteLine("Was there anything special today? ");
            case 3:
                Console.WriteLine("Did you have work or do homework today? ");
            case 4:
                Console.WriteLine("Did you find the love of your life? ");
            case 5:
                Console.WriteLine("Did you play a game today? ");
            case 6:
                Console.WriteLine("Were you embarassed today? ");
            case 7:
                Console.WriteLine("If you were an animal, what would you end up being? ");
            case 8:
                Console.WriteLine("Have you felt the spirit today? ");
            case 9:
                Console.WriteLine("Have you felt a desire to change today? ")
    }
}
