using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?: ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letter = "";
        string completion = "";

//Calculate grade percentage
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

//Calculate course completion. Attach completion message to variable.
        if (percent >=70)
        {
            completion = "Congratulations! You have passed the course!";
        }
        else
        {
            completion = "You have failed the course... You'll do better next time!";
        }


        Console.WriteLine($"Your grade: {letter}\n{completion}");
        
    }
}