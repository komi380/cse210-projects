// EXCEED REQUIREMENTS:
// I added a ScriptureLibrary with multiple scriptures.
// The program now picks a random scripture each time
// and can switch to a new one automatically or with "next".

using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        bool quit = false;

        while (!quit)
        {
            Scripture scripture = library.GetRandomScripture();

            while (!scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to continue, type 'next' for a new scripture, or 'quit' to exit.");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    quit = true;
                    break;
                }
                else if (input.ToLower() == "next")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWords();
                }
            }

            if (!quit)
            {
                Console.Clear();
                Console.WriteLine("Switching to another scripture...\n");
                System.Threading.Thread.Sleep(1500);
            }
        }

        Console.Clear();
        Console.WriteLine("Program ended. Goodbye!");
    }
}
