using System;
using System.Runtime.CompilerServices;

class Course
{

    public string _classCode;

    public string _className;

    public int _credits;

    public string _colour;

    // methods
    public void Display()
    {
        Console.WriteLine($"{_classCode} {_className} {_credits} {_colour}");
    }
}