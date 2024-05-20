using System;
using System.Collections.Generic;

public class Scripture
{
    public List<Scripture> _scripture = new List<Scripture>();
    private string JMproName = "collection.txt";
    private string JMitem;
    private string JMtext;
    public int JMkey;
    public string JMscriptText;



    public void LoadScriptures()
    {
        List<string> readText = File.ReadAllLines(JMproName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Scripture entry = new Scripture();

            entry.JMitem = entries[0];
            entry.JMtext = entries[6];

            _scripture.Add(entry);
        }
    }

    public void ScriptureDisplay()
    {
        foreach (Scripture item in _scripture)
        {
            item.ShowScripture();
        }
    }
    public void ShowScripture()
    {
        Console.WriteLine($"\n{JMtext}");
    }

    public int GetRandomIndex()
    {
        var random = new Random();
        JMkey = random.Next(_scripture.Count);
        return JMkey;
    }

    public string RandomScripture()
    {
        JMkey = GetRandomIndex();
       return JMscriptText = _scripture[JMkey].JMtext;
    }

    public void HideWords()
    {
        Word DEshown = new Word(_scripture);
        DEshown.visibility(_scripture);
    }


    public void GetRenderedText()
    {

    }
    public void IsCompletelyHidden()
    {

    }

    public void Referring()
    {
        Reference info = new Reference();
        info.refer();
    }


}