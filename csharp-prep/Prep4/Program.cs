using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userInput != 0)
        {
            Console.Write("Enter a number: ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        //Calculate the sum of numbers.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Calculate the average of numbers.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the largest number in the numbers list.
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }

        Console.WriteLine($"The largest number is: {max}");

    }
}