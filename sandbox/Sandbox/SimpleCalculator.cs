using System;

class SimpleCalculator
{

    public string Calculate()
    {
        double answer=0;
        Console.WriteLine("Enter 2 whole numbers you want to calculate.");
        int number1 = Int32.Parse(Console.ReadLine());
        int number2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("What would you like to do? (Enter as 1, 2, 3, or 4)");
        Console.Write("1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide \n");
        int mathType = Int32.Parse(Console.ReadLine());

        if (mathType == 1)
        {
            // Add
            answer = Add(number1, number2);
        }
        else if (mathType == 2)
        {
            // Subtract
            answer = Subtract(number1, number2);
        }
        else if (mathType == 3)
        {
            // Multiply
            answer = Multiply(number1, number2);
        }
        else if (mathType == 4)
        {
            // Divide
            answer = Divide(number1, number2);
        }
        else
        {
            Console.WriteLine("Incorrect Input.");
        }

        return " "+answer;
    }


    public double Add(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine("The sum of "+num1+" and "+num2+" equals "+sum);
        return sum;
    }


    public double Subtract(int num1, int num2)
    {
        double sum = 0;
        int choice;
        Boolean correct = false;
        
        while (correct == false)
        {
            Console.WriteLine("What is the number being divided? (enter 1 or 2)");
            choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                sum = num1 / num2;
                Console.WriteLine("The dividend of "+num1+" being divided by "+num2+" equals "+sum);
                correct = true;
            }
            else if (choice == 2)
            {
                sum = num2 / num1;
                Console.WriteLine("The dividend of "+num2+" being divided by "+num1+" equals "+sum);
                correct = true;
            }
            else
            {
                Console.WriteLine("Invalid Input, You can try again if you want.");
            }
        }

        return sum;
        
    }

    public double Multiply(int num1, int num2)
    {
        int multiplier = num1 + num2;
        Console.WriteLine("The sum of "+num1+" and "+num2+" equals "+multiplier);
        return multiplier;
    }

    public double Divide(int num1, int num2)
    {
        double dividend = 0;
        int choice;
        Boolean correct = false;
        
        while (correct == false)
        {
            Console.WriteLine("What is the number being divided? (enter 1 or 2)");
            choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                dividend = num1 / num2;
                Console.WriteLine("The dividend of "+num1+" being divided by "+num2+" equals "+dividend);
                correct = true;
            }
            else if (choice == 2)
            {
                dividend = num2 / num1;
                Console.WriteLine("The dividend of "+num2+" being divided by "+num1+" equals "+dividend);
                correct = true;
            }
            else
            {
                Console.WriteLine("Invalid Input, You can try again if you want.");
            }
        }

        return dividend;
        
    }
}