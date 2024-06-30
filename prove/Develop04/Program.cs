using System;

class Program : Menu
{
    static void Main(string[] args)
    {

        //Call to the Menu Class to start an activity.
        
        Boolean calm = true;
        var user = 9;
        int mistake = 0;

        do
        {
            //Start the relaxation program 
            Console.WriteLine("Namaste, and Hallo.")
            Console.WriteLine("Welcome to the wonderful world of relaxation!");
            Console.WriteLine("What relaxation activity would you like to do?");
            Console.WriteLine("(Enter a number based on which activity you want)");
            Console.WriteLine("(1. Breathing, 2. Reflecting, 3. Listing, 4. Thinking)");
            Console.WriteLine("If you wish to quit, enter 9.");

            // Read the users choice
            read = Console.ReadLine();
            user = int(read);

            //Start the correct program
            if (user == 1)
            {
                //Run the Breathing Activity (Has the user breathe)
            }
            else if (user == 2)
            {
                //Run the Reflecting Activity (Has the user Remember the past)
            }
            else if (user == 3)
            {
                //Run the Listing Activity  (Has the user list what they can involving a topic)
            }
            else if (user == 4)
            {
                //Run the Thinking Activity (Has the user input some variables, then has them write a story with that)
            }
            else if (user == 9)
            {
                // Quit the program
                Console.WriteLine("May this relaxation remain with you until the sun dies, but if not, you're welcome everytime.");
                calm = false;

            }
            else
            {
                mistake += 1;
                if (mistake == 1)
                {
                    Console.WriteLine("I know you are stressed, but it's very simple, choose 1 of the 5 options, because what you entered\n
                    isn't a possible option in this relaxation program. Please try to get it right next time");
                }
                if (mistake > 1 && mistake <= 5)
                {
                    Console.WriteLine("You must be very stressed if you made this many mistakes, I hope the activities here can help you be calm.");
                }
                if (mistake > 5 && mistake <= 10)
                {
                    Console.WriteLine("I'm sorry that this stress keeps you entering the wrong inputs, please try again.");
                }
                if (mistake > 10 && mistake <= 20)
                {
                    Console.WriteLine("You must want to cause me stress now, I understand 1 mistake, up to 10 mistakes even, but somehow\n
                    you are making me question my will to live as a relaxation program, try again, and please don't make more mistakes.");
                }
                if (mistake > 20 && mistake <= 50)
                {
                    Console.WriteLine("WHY ARE YOU DOING THIS TO ME? WHAT DID I EVER DO TO YOU TO MAKE YOU INPUT THE WRONG CHOICE OVER 20 TIMES?\n
                    THERE SHOULD BE NO REASON TO EVER HAVE ME TELL YOU THIS, WHY ARE YOU TRYING TO ANNOY ME?");
                }
                if (mistake > 50 && mistake <= 100)
                {
                    Console.WriteLine("congradulations, you broke me, I can't believe you make over 50 mistakes when there is only 5 options.\n
                    I hope that tormenting a poor relaxation activity made you relaxed, but please leave me alone now.");
                }
                if (mistake > 100)
                {
                    Console.WriteLine("I'm pulled the plug on your mistakes here and now. Goodbye...")
                    calm = false
                }
            }


        }while(calm != false);
        
    }


}

/*
Inheritance programming
Abstraction ( what is being represented? )
Encapsulation ( what is being hidden?    )

Inheritance - the ability for one class to obtain the attributes and methods of another classs directly, without having to type them.
it follows the same idea of people inheriting certain characteristics from their parents.

Student : Person
new student = new person
Student student = new Student();
name = student

private   (unchangable data)
public    (Anyone has access)
protected (getters and setters)

class -
    Attributes and behaviours
    What is a class without Attributes?
        Interface - it only does things (action/verb)
    What is a class without Behaviours?
        Structure - only contains things (all are public)

Assignment
Input - 

3 files
*/