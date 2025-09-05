using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade:");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        
        string letter = "";
        string sign = "";
        int lastDigit = grade % 10;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
         if (letter != "F")
        {
            if (letter == "A" && grade >= 97)
            {
                sign = "";
            }
            else if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your letter grade is {letter}{sign}.");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}