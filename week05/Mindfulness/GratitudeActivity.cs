using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "What is one thing you are grateful for today?",
        "Who in your life are you most thankful for?",
        "What recent event made you smile?",
        "What is something small you appreciate every day?"
    };

    public GratitudeActivity() 
        : base("Gratitude", "This activity will help you focus on gratitude by writing down things you are thankful for.") {}

    public void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Write something you are grateful for: ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} things you are grateful for.");
        End();
    }
}
