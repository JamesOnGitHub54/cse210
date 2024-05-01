using System;

class Program
{
    static void Main(string[] args)
    {
        //User creates a magic number
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher\nWhat is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Lower\nWhat is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("You guessed it!");
    }
}