using System;

class Exercise2
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 92)
        {
            letter = "A";
        }
        else if (percent >= 82)
        {
            letter = "B";
        }
        else if (percent >= 72)
        {
            letter = "C";
        }
        else if (percent >= 62)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 72)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}