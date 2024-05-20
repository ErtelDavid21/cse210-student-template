/* 
Memorization Program
CSE210
Word Program: Hides random words from a given list and gives the new list back

David Ertel
(c)2023
*/

using System;
using System.Threading;

public class Word
{
    public string[] DE_phrase = ;
    public List<> _DEverse;
    static Random DErnd = new Random();


    public visibility(DEverse)
    {     
        //Splits the verse into individual words
        DE_phrase = DEverse.Split();

        //loops through the list to randomly hide words.      
        foreach (var DEwords in DE_phrase)
        {

            int DEnum = DErnd.Next(0, 10);
            if (DEnum >= 8)
            {
                var DEremovedWords = DE_phrase[DEwords].gosilent();
           
            }
        }
        return(DE_phrase);
    }
}


// code assisters
/*
Random rnd = new Random();
var s = "12345";
var result = s.ToArray();
var randomIds = Enumerable.Range(0, s.length).OrderBy(x => rnd.Next()).Take(3);
foreach (var)
*/

//string = string.replace("","")


//https://www.c-sharpcorner.com/forums/remove-words-from-a-string-in-random-order
//
/*using System;
using System.Threading;

class Program
{
    static Random rand = new Random();

    static void Main()
    {
       string text = "This is a very big apple.";
       
       while (true)
       { 
         Console.WriteLine(text);
         string[] words = text.Split(' ');
         int numWords = words.Length;
         bool delay = true;

         for(int i = 1; i <= numWords; i++)
         {
            if (delay) Thread.Sleep(1000);
            int randNum = rand.Next(0, numWords);
            string randWord = words[randNum];

            if (randWord[0] != '_')
            {
               words[randNum] = new string('_', randWord.Length);
               Console.WriteLine(String.Join(" ", words));
               delay = true;
            }
            else
            {
               i--;
               delay = false;
            } 
         }     
         Console.WriteLine();
         string yn;

         do
         {
            Console.Write("Do it again y/n :  ");
            yn = Console.ReadLine().ToLower();
         }
         while(yn != "y" && yn != "n");

         if (yn == "n") return;
         Console.WriteLine();
       }   
    }
}*/