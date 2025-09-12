using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a CSV file");
            Console.WriteLine("4. Load the journal from a CSV file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save (e.g., journal.csv): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToCsv(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load (e.g., journal.csv): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromCsv(loadFile);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}

/* Here is the addition I was able to make Instead of saving to a simple text file, this version saves and loads journal entries
    in a proper CSV (Comma-Separated Values) format that can be opened in Microsoft Excel
    or Google Sheets.

    - Each field is enclosed in quotes if needed.
    - Quotes inside fields are doubled (" -> "") according to CSV standards.
    - The program writes a header row: Date, Prompt, Response.
    - The Load method skips the header row and correctly parses CSV content.
*/