using System;

public class Assignment
{
    private string _student_Name;
    private string _topic;

    public static string GetSummary()
    {
        Console.WriteLine("Enter your name: ");
        string _student_Name = Console.ReadLine();

        Console.WriteLine("What topic?");
        string _topic = Console.ReadLine();
        return (_student_Name, _topic);
    }

}