using System;
using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    {
        FavoriteQuote quote = new FavoriteQuote();
        MadLibsGame play = new MadLibsGame();
        SimpleCalculator math = new SimpleCalculator();
        UnitConversionTool measure = new UnitConversionTool();


        Console.WriteLine("What would you like to do? ");
        Console.Write("1. Store a favorite quote. \n 2. Play a Madlibs Game. \n 3. Simple Calculator \n 4. Convert from English units to Metric. \n");
        string choice = (Console.ReadLine());

        if (choice == "3")
        {
            math.Calculate();
        }
        /*
        Course course1 = new Course();
        course1._classCode = "CSE 210";
        course1._className = "Programming with Classes";
        course1._credits = 2;
        course1._colour = "green";

        //methods
        course1.Display();*/
    }
}