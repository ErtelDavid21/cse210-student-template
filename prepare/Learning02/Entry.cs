using System;

class Entry
{
    public static void entrySave(object obj, string fileName)
    {
        var options = new JsonSerializerOptions(_options) 
        { 
        WriteIndented = true
        };
        var jsonString = JsonSerializer.Serialize(obj, options);
        File.WriteAllText(fileName, jsonString);
    }

    

    public static void journalEntry()
    {
        Console.WriteLine("Would you like a random prompt? ")
        var answer = Console.ReadLine();
        

    }
}