using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNomber = randomGenerator.Next(1, 11);
        int guess = -1;

        while (guess != magicNomber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if (guess == magicNomber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNomber)
            {
                Console.WriteLine("Highter.");
            }
            else
            {
                Console.WriteLine("lower.");
            }
        }
        Console.WriteLine("Do you want to play again? (yes or no)");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "yes")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thank you for playing. Goodbye!");
        }
    }
}