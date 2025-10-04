using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() 
        : base("Reflection", "This activity will help you reflect on moments of strength and resilience.") {}

    public void Run()
    {
        Start();
        Random rand = new Random();

        Console.WriteLine();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("\nThink about this experience...");
        Console.WriteLine("Press ENTER when you are ready to continue.");
        Console.ReadLine(); 

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("\nNow reflect on the following questions:\n");

        while (DateTime.Now < endTime)
        {
            string q = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(q);
            ShowSpinner(5);
        }

        End();
    }
}
