// -----------------------------------------------------
// Mindfulness Program - CSE 210
// Exceeding Requirement: I added a new type of activity 
// called "Gratitude Activity". In this activity, the user 
// is invited to write down things they are grateful for. 
// This encourages positivity and makes the program more 
// complete and personalized.
// -----------------------------------------------------

using System;

class Program
{
    static void Main(string[] args)
    {
         string choice = "";
        while (choice != "5")
        {
            Console.Clear(); 

            Console.WriteLine("\n=== Mindfulness Program Menu ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ReflectionActivity().Run();
            else if (choice == "3")
                new ListingActivity().Run();
            else if (choice == "4")
                new GratitudeActivity().Run();
            else if (choice != "5")
            {
                Console.WriteLine("Invalid choice. Try again.");
                Thread.Sleep(2000); 
            }

            if (choice != "5")
            {
                Console.WriteLine("\nPress ENTER to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}