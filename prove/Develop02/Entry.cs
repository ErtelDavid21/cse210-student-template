using System;

class Entry
{
    Journal addTo = new Journal();

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

        Console.WriteLine("");
        string entry = Console.ReadLine();

        addTo.journalEntry.JournalEntries.Add(entry);
    }
}