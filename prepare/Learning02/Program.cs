using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your diary, don't forget to hide this from prying eyes.");
        Boolean writing = true;
        Journal diary = new Journal();

        while (writing != false)
        {
            diary.journalLoad(writing);
        }
    }
}