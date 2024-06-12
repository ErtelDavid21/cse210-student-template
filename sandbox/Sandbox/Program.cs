using System;
using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    {
        Course course1 = new Course();
        course1._classCode = "CSE 210";
        course1._className = "Programming with Classes";
        course1._credits = 2;
        course1._colour = "green";

        //methods
        course1.Display();
    }
}